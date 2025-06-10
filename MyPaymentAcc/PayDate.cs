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
    public partial class PayDate : Form
    {
        public Payment CreatedPayment { get; private set; }//св-во для передачи созданного платежа обрато в мейн форм
        public PayDate(string paymentType)
        {
            InitializeComponent();
            labelType.Text = paymentType;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dateTimePicker.Value;
                decimal amount = decimal.Parse(textBoxAmount.Text);

                CreatedPayment = new Payment(labelType.Text, amount, dt);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch 
            {
                MessageBox.Show("ПЖ введите правильную сумму", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
