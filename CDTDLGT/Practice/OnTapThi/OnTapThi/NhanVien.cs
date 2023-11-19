using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTapThi
{
    public class NhanVien
    {
        //fields
        private string maNhanVien;
        private string tenNhanVien;
        private int tuoi;

        //properties
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }


        //constructors
        public NhanVien(string maNV, string tenNV, int tuoiNV)
        {
            this.maNhanVien = maNV;
            this.tenNhanVien = tenNV;
            this.tuoi = tuoiNV;
        }

        public NhanVien()
        {
            this.maNhanVien = "";
            this.tenNhanVien = "";
            this.tuoi = 0;
        }

        //methods
        public string toString()
        {
            return $"{this.maNhanVien, -15}{this.tenNhanVien, -15}{this.tuoi, 15}";
        }
    }
}