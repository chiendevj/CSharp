using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap2
{
    public class NhanVienHD:Nguoi
    {
        //  fields
        private string _maHD;
        private double _luongNgay;
        private double _soNgayLamViec;
        private double _phuCap;

        // properties
        public string MaHD { get => _maHD; set => _maHD = value; }
        public double LuongNgay { get => _luongNgay; set => _luongNgay = value; }
        public double SoNgayLamViec { get => _soNgayLamViec; set => _soNgayLamViec = value; }
        public double PhuCap { get => _phuCap; set => _phuCap = value; }

        // constructor
        public NhanVienHD(string ten, Date ngaySinh, string soDT, string diaChi, string maHD, double luongNgay, double soNgayLamViec, double phuCap) :base(ten, ngaySinh, soDT, diaChi)
        {
            MaHD = maHD;
            LuongNgay = luongNgay;
            SoNgayLamViec = soNgayLamViec;
            PhuCap = phuCap;
        }

        public NhanVienHD() : base()
        {
            MaHD = "";
            LuongNgay = 0d;
            SoNgayLamViec = 0d;
            PhuCap = 0d;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._maHD}#{this._luongNgay}#{this._soNgayLamViec}#{this._phuCap}");
        }

        public override double TinhLuong()
        {
            return ((_soNgayLamViec > 20) ? (this._soNgayLamViec * this._luongNgay + this._phuCap + ((this._luongNgay  * this._soNgayLamViec)*(5/100))) : (this._soNgayLamViec * this._luongNgay + this._phuCap));
        }
    }
}