using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International
{
    class Order
    {
        private int orderID;
        private string customerID;
        private string customerName;
        private String customerContact;
        private string dateTime;
        private int singleSheetQty;
        private decimal singleSheetUnitPrice;
        private int dozenSheetQty;
        private decimal dozenSheetUnitPrice;
        private decimal amountPaid;
        private bool finished;
        private string description;
        private decimal amountRemaining;
        private decimal totalPrice;



        public Order(int orderID, string customerID, string customerName, string contact, string dateTime, int singleSheetQty, decimal singleSheetUnitPrice, int dozenSheetQty, decimal dozenSheetUnitPrice, decimal amountPaid, string description)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerContact = contact;
            this.dateTime = dateTime;
            this.singleSheetQty = singleSheetQty;
            this.singleSheetUnitPrice = singleSheetUnitPrice;
            this.dozenSheetQty = dozenSheetQty;
            this.dozenSheetUnitPrice = dozenSheetUnitPrice;

            this.amountPaid = amountPaid;
            finished = false;
            this.description = description;
            Console.WriteLine("Order created");
        }

        public int getOrderID()
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

        public string getDateTime()
        {
            return dateTime;
        }

        public String getCustomerId()
        {
            return customerID;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public string getCustomerContact()
        {
            return customerContact;
        }

        public decimal getSingleUnitPrice()
        {
            return singleSheetUnitPrice;
        }

        public decimal getDozenUnitPrice()
        {
            return dozenSheetUnitPrice;
        }

        public decimal getAmountPaid()
        {
            return amountPaid;
        }

    }
}
