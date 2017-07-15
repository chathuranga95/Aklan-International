using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International
{
    class Order
    {
        private string orderID;
        private string customerID;
        private string customerName;
        private DateTime dateTime;
        private int singleSheetQty;
        private decimal singleSheetUnitPrice;
        private int dozenSheetQty;
        private decimal dozenSheetUnitPrice;
        private decimal amountPaid;
        private bool finished;
        private string description;
        private decimal amountRemaining;
        private decimal totalPrice;


        public Order(string orderID, string customerID, string customerName, DateTime dateTime, int singleSheetQty, decimal singleSheetUnitPrice, int dozenSheetQty, decimal dozenSheetUnitPrice, decimal amountPaid,string description)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.customerName = customerName;
            this.dateTime = dateTime;
            this.singleSheetQty = singleSheetQty;
            this.singleSheetUnitPrice = singleSheetUnitPrice;
            this.dozenSheetQty = dozenSheetQty;
            this.dozenSheetUnitPrice = dozenSheetUnitPrice;
            this.amountPaid = amountPaid;
            finished = false;
            this.description = description;
        }

        public string getOrderID()
        {
            return orderID;
        }

        public string getDescription()
        {
            return description; 
        }

        public decimal getTotalPrice()
        {
            totalPrice = singleSheetQty * singleSheetUnitPrice + dozenSheetQty * dozenSheetUnitPrice;
            return totalPrice;
        }

        public decimal getRemainingPrice()
        {
            amountRemaining = totalPrice - amountPaid;
            return amountRemaining;
        }

        public int getSingleQty()
        {
            return singleSheetQty;
        }
        public int getDozenQty()
        {
            return dozenSheetQty;
        }
        public void setFinished()
        {
            finished = true;
        }
    }
}
