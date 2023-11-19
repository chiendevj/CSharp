using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Ch4
{
    abstract class Employee
    {
        // fields
        private int _empCode;
        private string _firstName;
        private string _lastName;

        // properties
        public int EmpCode
        {
            get
            {
                return _empCode;
            }

            set
            {
                _empCode = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        // contructors
        public Employee(int _empCode, string _firstName, string _lastName)
        {
            this._empCode = _empCode;
            this._firstName = _firstName;
            this._lastName = _lastName;
        }

        // methor
        public abstract double pay();
        public abstract string toString();
    }
}
