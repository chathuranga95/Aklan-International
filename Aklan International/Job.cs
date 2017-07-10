using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International
{
    class Job
    {
        private string empID;
        private int index;
        private string matType;
        private int qty;
        private bool finished;
        private string date;

        public Job(string empID, int index, string matType, int qty, bool finished, string date)
        {
            this.empID = empID;
            this.index = index;
            this.matType = matType;
            this.qty = qty;
            this.finished = finished;
            this.date = date;
        }

        public void setFinished(bool state)
        {
            this.finished = state;
        }
        public string getEmpID()
        {
            return empID;
        }
        public int getIndex()
        {
            return index;
        }

        public string getMatType()
        {
            return matType;
        }

        public int getQty()
        {
            return qty;
        }
        public string getDate()
        {
            return date;
        }
    }
}
