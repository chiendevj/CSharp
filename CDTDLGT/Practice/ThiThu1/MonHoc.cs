using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
{
    internal class MonHoc
    {
        // fields
        private string ma;
        private string ten;
        private int soTC;

        // properties
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SoTC { get => soTC; set => soTC = value; }

        // constructor
        public MonHoc() 
        {
            this.ma = "";
            this.ten = "";
            this.soTC = 0;
        }

        public MonHoc(string maMH, string tenMh, int soTinChi)
        {
            this.ma = maMH;
            this.ten = tenMh;
            this.soTC = soTinChi;
        }

        // method
        public string toString()
        {
            return ($"|{this.ma,-15}|{this.ten, -15}|{this.soTC,15}|");
        }

    }
}
