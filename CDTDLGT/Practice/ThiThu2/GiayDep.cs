using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu2
{
    internal class GiayDep
    {
        // fields
        private string ma;
        private string ten;
        private int gia;

        // properties
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
        
        // construcotr
        public GiayDep() 
        {
            this.ma = "";
            this.ten = "";
            this.gia = 0;
        }    

        public GiayDep(string ma, string ten, int gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.gia = gia;
            
        }

        public string toString()
        {
            return ($"{this.ma, -15}{this.ma,-15}{this.ma, 15}");
        }
    }
}
