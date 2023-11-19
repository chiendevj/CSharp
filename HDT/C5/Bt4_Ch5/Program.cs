using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt4_Ch5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat conCat = new Cat("HHHI");
            conCat.setname(conCat.getName());
            Console.WriteLine(conCat.getName());
            conCat.play();
            Console.WriteLine(conCat.eat());
            Console.WriteLine(conCat.walk());

            Spider spider = new Spider();
            Console.WriteLine(spider.eat());
            Console.WriteLine(spider.walk());

            //Fish conFish = new Fish("hihi");
            //conFish.setName(conFish.getName());
            //Console.WriteLine(conFish.walk());
            //Console.WriteLine(conFish.eat());
            //Console.WriteLine(conFish.play());



        }
    }
}
