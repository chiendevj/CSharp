using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2
{
    abstract class GiangVien
    {
        // field
        private Nguoi thongTinNV;


        // properties
        internal Nguoi ThongTinNV
        {
            get
            {
                return thongTinNV;
            }

            set
            {
                thongTinNV = value;
            }
        }

        // Constructor
        public GiangVien()
        {

        }

        public GiangVien(Nguoi thongTinNV)
        {
            this.thongTinNV = thongTinNV;
        }

        //Method
        public abstract string toString();
       
        public abstract double getLuong();
    }

}
