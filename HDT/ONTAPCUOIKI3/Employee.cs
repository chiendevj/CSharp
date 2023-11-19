using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public abstract class Employee
    {
        private string employeeID;
        protected Person contact;
        private static int countOfEmployee = 0;
        private DateTime startDate;

        public string EmployeeID{
            get {
                return this.employeeID;
            }
        }

        public static int CountOfEmployee{
            get {
                return countOfEmployee;
            }
        }

        public Employee()
        {
            this.employeeID = "";
            this.contact = new Person();
            this.startDate = new DateTime();
            countOfEmployee++;
        }

        public Employee(string employeeID,Person contact, DateTime startDate)
        {
            if (employeeID.Length != 7)
            {
                throw new Exception("length not !=7");
            }else{
                this.employeeID = employeeID;
            }
            this.contact = contact;
            this.startDate = startDate;
            countOfEmployee++;
        }

        public new  string ToString()
        {
            return $"{this.employeeID}#{this.contact.ToString()}#{this.startDate}";
        } 
    }
}