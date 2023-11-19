using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_
{
    internal abstract class Employee
    {
        private int _empCode;
        private string _firstName;
        private string _lastName;

        public Employee(int empCode, string firstName, string lastName)
        {
            this._empCode = empCode;
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public int EmpCode { get => _empCode; set => _empCode = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public abstract string toString();
        

        public abstract double pay();
    }
}
