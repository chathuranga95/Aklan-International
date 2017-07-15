using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International.CreateNewOrder
{
    class Order
    {
        private int orderId;
        private String customerName, customerNIC , customerContact;
        private decimal total;

        public Order(String customerName, String customerNIC, String customerContact)
        {
            this.customerName = customerName;
            this.customerNIC = customerNIC;
            this.customerContact = customerContact;

            
        }

        public void addToTotal(decimal Total)
        {
            total = total + Total;
        }

        public void subFromTotal(decimal Total)
        {
            total = total - Total;
        }

        public decimal getTotal()
        {
            return total;
        }

        

        
        
    }
}
