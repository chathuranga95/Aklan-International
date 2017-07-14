using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International
{
    class SalesOrder
    {
        private string customerName;
        private string NIC;
        private string tel;
        private string type;
        private int qty;
        private decimal unitPrice;
        private int amount;

        public SalesOrder(string customerName, string nIC, string tel, string type, int qty, decimal unitPrice, int amount)
        {
            this.customerName = customerName;
            NIC = nIC;
            this.tel = tel;
            this.type = type;
            this.qty = qty;
            this.unitPrice = unitPrice;
            this.amount = amount;
        }
    }
}
