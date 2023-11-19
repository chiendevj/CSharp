using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4_CT5
{
    public abstract class Animal
    {
        //field
        private int legs;

        //properties
        protected int Legs
        {
            get
            {
                return legs;
            }

            set
            {
                legs = value;
            }
        }

        //constructor

        public Animal(int legs)
        {
            this.legs = legs;
        }

        public Animal()
        {
            this.legs = 0;
        }

    }
}