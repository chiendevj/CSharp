using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap2
{
    public class NhanVienBC:Nguoi
    {
        // fields
        private string _maBC;
        private double _luongCB;
        private double _heSoLuong;
        private double _phuCap;

        // properties
        public string MaBC { get => _maBC; set => _maBC = value; }
        public double LuongCB { get => _luongCB; set => _luongCB = value; }
        public double HeSoLuong { get => _heSoLuong; set => _heSoLuong = value; }
        public double PhuCap { get => _phuCap; set => _phuCap = value; }

        // Constructor
        public NhanVienBC(string ten, Date ngaySinh, string soDT, string diaChi, string maBC, double luongCB, double heSoLuong, double phuCap) : base(ten, ngaySinh, soDT, diaChi)
        {
            _maBC = maBC;
            _luongCB = luongCB;
            _heSoLuong = heSoLuong;
            _phuCap = phuCap;
        }

        public NhanVienBC():base()
        {
            _maBC = "";
            _luongCB = 0d;
            _heSoLuong = 0d;
            _phuCap = 0d;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._maBC}#{this._luongCB}#{this._heSoLuong}#{this._phuCap}");
        }

        public override double TinhLuong()
        {
            return (this._heSoLuong * this._luongCB + this._phuCap);
        }

    }
}