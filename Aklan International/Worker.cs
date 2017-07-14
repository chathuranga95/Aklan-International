using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aklan_International
{
    class Worker
    {
        private String firstName;
        private String lastName;
        private String empID;
        private String password;
        private String NIC;
        private String gender;
        private String address;
        private String DOB;
        private int tel;
        private String bankAcc;
        private bool active;
        private String type;


        public Worker(string firstName, string lastName, string empID, string password, string nIC, string gender, string address, string dOB, int tel, string bankAcc, string type, bool active)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            this.password = password;
            NIC = nIC;
            this.gender = gender;
            this.address = address;
            DOB = dOB;
            this.tel = tel;
            this.bankAcc = bankAcc;
            this.type = type;
            this.active = active;
        }
        public string getEmpID()
        {
            return empID;
        }
        public string getFirstName()
        {
            return firstName;
        }

        public string getPass()
        {
            return password;
        }

        public bool getActiveStatus()
        {
            return active;
        }
    }
}
