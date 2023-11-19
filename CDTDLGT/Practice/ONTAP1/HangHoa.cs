using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP1
{
    internal class HangHoa
    {
        // Fields
        private string maHang;
        private string tenHang;
        private int giaBan;

        // Properties
        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }

        // Constructor
        public HangHoa() 
        {
            this.MaHang = "";
            this.tenHang = "";
            this.giaBan = 0;

        }
        public HangHoa(string ma, string ten, int gia)
        {
            this.maHang = ma;
            this.tenHang = ten;
            this.giaBan = gia;
        }

        public HangHoa(HangHoa hh)
        {
            this.maHang = hh.maHang;
            this.tenHang = hh.tenHang;
            this.giaBan = hh.giaBan;
        }

        // Method
        public string toString()
        {
            return $"|{this.maHang,-15}|{this.tenHang,-15}|{this.giaBan,15}|";
        }

    }
}
