using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_Chuong4
{
    class DonThuc
    {
        private int heSoDT;
        private int bacDT;
       
        // properties
        public int HeSoDT
        {
            get
            {
                return heSoDT;
            }

            set
            {
                heSoDT = value;
            }
        }

        public int BacDT
        {
            get
            {
                return bacDT;
            }

            set
            {
                bacDT = value;
            }
        }

        
        // Contructor
        public DonThuc()
        {
           
            this.heSoDT = 1;
            this.BacDT = 1;
        }

        public DonThuc(int hesoDT, int bacDT)
        {
            this.bacDT = bacDT;
            this.heSoDT = hesoDT;
           
        }

        // method
        public new string ToString()
        {
            if (this.bacDT == 0)
            {
                return ($"{this.heSoDT}");
            }
            else if (this.bacDT == 1)
            {
                return ($"{this.heSoDT}X");
            }
            return ($"{this.heSoDT}X^{this.bacDT}");
        }

        public double getGiaTri(int x)
        {
            return (this.heSoDT * Math.Pow(x, this.bacDT));
        }

        public static DonThuc operator +(DonThuc dt1, DonThuc dt2)
        {
            DonThuc total = new DonThuc();
            total.HeSoDT = dt1.HeSoDT + dt2.HeSoDT;
            total.BacDT = dt1.bacDT;
            return total;
        }

        public static DonThuc operator -(DonThuc dt1, DonThuc dt2)
        {
            DonThuc total = new DonThuc();
            total.HeSoDT = dt1.HeSoDT - dt2.HeSoDT;
            total.BacDT = dt1.bacDT;
            return total;
        }

        public static DonThuc operator *(DonThuc dt1, DonThuc dt2)
        {
            DonThuc total = new DonThuc();
            total.HeSoDT = dt1.HeSoDT * dt2.HeSoDT;
            total.BacDT = dt1.bacDT + dt2.bacDT;
            return total;
        }

        public static DonThuc operator /(DonThuc dt1, DonThuc dt2)
        {
            DonThuc total = new DonThuc();
            total.HeSoDT = dt1.HeSoDT / dt2.HeSoDT;
            total.BacDT = dt1.bacDT - dt2.bacDT;
            return total;
        }
    }
}
