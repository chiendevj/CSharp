using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt4_Ch5
{
    class Spider : Animal
    {
        public Spider() : base(8)
        {
          
        }
        public override string walk()
        {
            return ("Di bang 8 chan.");
        }

        public override string eat()
        {
            return ("An con trung.");
        }
    }
}
