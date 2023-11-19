using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt4_Ch5
{
    abstract class Animal
    {
        // field
        private int _leg;

        // constructor
        public Animal(int _leg)
        {
            this._leg = _leg;
        }

        // properties
        public int Leg
        {
            get
            {
                return _leg;
            }

            set
            {
                _leg = value;
            }
        }

        // method
        public abstract string walk();
        public abstract string eat();
    }
}
