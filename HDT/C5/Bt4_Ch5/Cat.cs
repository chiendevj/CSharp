using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt4_Ch5
{
    class Cat : Animal, IPet
    {
        // Fields
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

        public void setname(string name)
        {
            this.name = name;
        }
        public Cat (string name) : base(4)
        {
            this.name = name;
        }

       public void play()
        {
            Console.WriteLine("Choi bong ro");
        }

        public override string walk()
        {
            return $"Di bang {base.Leg} chan";
        }

        public override string eat()
        {
            return "An ca";
        }



    }
}
