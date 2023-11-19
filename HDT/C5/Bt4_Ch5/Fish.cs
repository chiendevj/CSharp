using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt4_Ch5
{
    internal class Fish: Animal, IPet
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string getName()
        {
            return this.name;
        }

        public Fish(string name) : base(0)
        {
            this.name = name;
        }

        public override string eat()
        {
            return "An rong bien";
        }

        public override string walk()
        {
            return $"Di bang {base.Leg} chan";
        }

        public void play()
        {
            Console.WriteLine("Choi bong chay!");
        }
    }
}
