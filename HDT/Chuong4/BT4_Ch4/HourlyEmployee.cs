using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Ch4
{
    class HourlyEmployee : Employee
    {
        // fields
        private double _rate;
        private double _workingHours;

        // properties
        public double Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                _rate = value;
            }
        }

        public double WorkingHours
        {
            get
            {
                return _workingHours;
            }

            set
            {
                _workingHours = value;
            }
        }

        // contructors
        public HourlyEmployee(int empCode, string firstName, string lastName, double rate, double wkH) : base(empCode, firstName, lastName)
        {
            base.EmpCode = empCode;
            base.FirstName = firstName;
            base.LastName = lastName;
            this._rate = rate;
            this._workingHours = wkH;
        }

        // method
        public override double pay()
        {
            return (this._rate * this._workingHours);
        }
        public override string toString()
        {
            string s = "";
            s += ($"{base.EmpCode,-15}{base.FirstName,-15}{base.LastName,-15}{pay(),-15}");
            return s;
        }

    }
}
