using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaymentAcc
{
    public partial class FormMain : Form
    {
        private List<Payment> scheduledPayments = new List<Payment>();//Коллекция для хранения всех запланированных платежей
        public FormMain()
        {
            InitializeComponent();
            

            listViewPayAcc.View = View.Details;
            listViewPayAcc.Columns.Add("Type", 150);
            listViewPayAcc.Columns.Add("Amount", 100);
            listViewPayAcc.Columns.Add("Date & Time", 200);

            listBoxPayList.Items.AddRange(new object[]
            { "Аренда офиса", "Выплата зарплаты", "Коммунальные услуги", "Налоги", "Прочее" });

            listBoxPayList.DoubleClick += ListBoxPayList_DoubleClick;
        }

        private void ListBoxPayList_DoubleClick(object sender, EventArgs e)//?
        {
            if (listBoxPayList.SelectedItem == null)
            {
                return;
            }

            string type = listBoxPayList.SelectedItem.ToString();

            PayDate payDate = new PayDate(type);
            if (payDate.ShowDialog() == DialogResult.OK)
            {
                Payment p = payDate.CreatedPayment;
                scheduledPayments.Add(p);
                UpdatePayList();
            }
        }

        private void UpdatePayList()
        {
            scheduledPayments.Sort((x, y) => x.DateTime.CompareTo(y.DateTime)); //сортировка по дате

            listViewPayAcc.Items.Clear();

            foreach(var p in scheduledPayments)
            {
                ListViewItem item = new ListViewItem(p.Type);
                item.SubItems.Add(p.Amount.ToString("C"));//форматируем типа это валюта
                item.SubItems.Add(p.DateTime.ToString("g"));//дата и время
                listViewPayAcc.Items.Add(item);
            }
        }
    }
}

