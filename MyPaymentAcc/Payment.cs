using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaymentAcc
{
    public class Payment
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }

        public Payment(string type, decimal amount, DateTime dateTime)
        {
            Type = type;
            Amount = amount;
            DateTime = dateTime;
        }


    }
}
