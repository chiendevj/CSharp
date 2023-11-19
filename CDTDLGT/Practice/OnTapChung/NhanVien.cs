using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapChung
{
    internal class NhanVien
    {
        // fields
        private string maNV;
        private string tenNV;
        private int tuoiNV;

        // properties
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int TuoiNV { get => tuoiNV; set => tuoiNV = value; }

        // constructor
        public NhanVien() 
        {
            this.maNV = "";
            this.tenNV = "";
            this.tuoiNV = 0;
        }

        public NhanVien(string ma, string ten, int tuoi)
        {
            this.maNV = ma;
            this.tenNV = ten;
            this.tuoiNV = tuoi; 
        }

        // method
        public string toString()
        {
            return ($"|{this.maNV, -15}|{this.tenNV,-15}|{this.tuoiNV,15}|");
        }


    }
}
