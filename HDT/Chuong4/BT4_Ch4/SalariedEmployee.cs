using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Ch4
{
    class SalariedEmployee : Employee
    {
        // fields
        private double _commisionRate;
        private double _grossSales;
        private double _basic;

        // properties
        public double CommisionRate
        {
            get
            {
                return _commisionRate;
            }

            set
            {
                _commisionRate = value;
            }
        }

        public double GrossSales
        {
            get
            {
                return _grossSales;
            }

            set
            {
                _grossSales = value;
            }
        }

        public double Basic
        {
            get
            {
                return _basic;
            }

            set
            {
                _basic = value;
            }
        }

        // contructor
        public SalariedEmployee(int empCode, string firstName, string lastName, double commisionRate, double grossSales, double basic) : base(empCode, firstName, lastName)
        {
            base.EmpCode = empCode;
            base.FirstName = firstName;
            base.LastName = lastName;
            this._commisionRate = commisionRate;
            this._grossSales = grossSales;
            this._basic = basic;
        }

        // method
        public override double pay()
        {
            return (this._basic + (this._commisionRate * this._grossSales));
        }

        public override string toString()
        {
            string s = "";
            s += ($"{base.EmpCode,-15}{base.FirstName,-15}{base.LastName,-15}{pay(),-15}");
            return s;
        }
    }
}
