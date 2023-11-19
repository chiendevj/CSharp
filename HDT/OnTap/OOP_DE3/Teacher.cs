using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace OOP_DE3
{
    public class Teacher:Employee, IPay
    {
        // fields
        private float _rate;

        // properties
        public float Rate { get => _rate; set => _rate = value; }

        // constructor
        public Teacher():base()
        {
            _rate = 0;
        }

        public Teacher( string employeeID, Person ps, float rate):base(employeeID, ps)
        {
            this._rate = rate;
        }

        // method
        public override string ToString()
        {
            return base.ToString() + ($"#{this._rate}#{this.GetSalary()}");
        }

        public long GetSalary()
        {
            return (long)((2500000 * this._rate) < 4000000 ? (2500000 * this._rate) + (2500000 * this._rate) * 10 / 100 : 2500000 * this._rate);
        }
    }
}