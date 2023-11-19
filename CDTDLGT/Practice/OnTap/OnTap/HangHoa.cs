using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class HangHoa
    {
        //fields
        private string maHang;
        private string tenHang;
        private int giaBan;

        //properties
        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }

        //constrcutors
        public HangHoa()
        {
            this.maHang = "";
            this.tenHang = "";
            this.giaBan= 0;
        }

        public HangHoa(string ma, string ten, int gia)
        {
            this.maHang = ma;
            this.tenHang = ten;
            this.giaBan = gia;
        }

        //methods
        public string InThongTin()
        {
            return $"Ma hang: {this.maHang}\nTen hang: {this.tenHang}\nGia ban: {this.giaBan}";
        }

        public string ToPrint()
        {
            return $"{this.maHang,-15}{this.tenHang,-15}{this.giaBan, 15}";
        }


    }
}
