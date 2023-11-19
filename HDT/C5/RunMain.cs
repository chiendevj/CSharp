using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class C5
    {
        static void Main(string[] args)
        {
            MovablePoint mp = new MovablePoint(1,1,1,1);
            MovableCircle mc = new MovableCircle(3,mp);
            mp.moveUp();
            Console.WriteLine(mp.toString());
            Console.WriteLine(mc.toString());
        }
    }

}
