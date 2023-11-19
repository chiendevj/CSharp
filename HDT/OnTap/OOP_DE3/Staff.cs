using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_DE3
{
    public class Staff: Employee, IPay
    {
        // fields
        private long _mounthlySalary;
        private float _rate;

       // properties
        public long MounthlySalary { get => _mounthlySalary; set => _mounthlySalary = value; }
        public float Rate { get => _rate; set => _rate = value; }

        // constructor
        public Staff():base()
        {
            this._mounthlySalary = 0;
            this._rate = 0;
        }

        public Staff(string employeeID, Person ps, DateTime startDate, long mounthSalary, float rate) :base(employeeID, ps, startDate)
        {
            MounthlySalary = mounthSalary;
            Rate = rate;
        }

        // method
        public override string ToString()
        {
            return base.ToString() + ($"#{this._mounthlySalary}#{this._rate}#{this.GetSalary()}");
        }
        public long GetSalary()
        {
            return (long)(this._rate < 2.0 ? (this._mounthlySalary * this._rate) + (this._mounthlySalary * this._rate) * 5 /100 : (this._mounthlySalary * this._rate));
        }
    }
}