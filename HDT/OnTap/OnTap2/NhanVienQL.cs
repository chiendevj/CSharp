using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnTap2
{
    public class NhanVienQL:Nguoi
    {
        // fields
        private string _maQL;
        private double _luongCB;
        private double _heSoLuong;
        private double _heSoQL;

        // properties
        public string MaQL { get => _maQL; set => _maQL = value; }
        public double LuongCB { get => _luongCB; set => _luongCB = value; }
        public double HeSoLuong { get => _heSoLuong; set => _heSoLuong = value; }
        public double HeSoQL { get => _heSoQL; set => _heSoQL = value; }

        // constructor
        public NhanVienQL():base()
        {
            this._maQL = "";
            this._luongCB = 0d;
            this._heSoLuong = 0d;
            this._heSoQL = 0d;
        }

        public NhanVienQL(string ten, Date ngaySinh, string soDT, string diaChi, string maQL, double luongCB, double heSoLuong, double heSoQL) :base(ten, ngaySinh, soDT, diaChi)
        {
            _maQL = maQL;
            _luongCB = luongCB;
            _heSoLuong = heSoLuong;
            _heSoQL = heSoQL;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._maQL}#{this._luongCB}#{this._heSoLuong}#{this._heSoLuong}");
        }

        // tinh luong
        public override double TinhLuong()
        {
            return ((this._heSoQL > 2.5) ? ((this._heSoLuong * this._luongCB) + (this._heSoQL * this._luongCB + (this._luongCB * 5/ 100))) : ((this._heSoLuong * this._luongCB) + (this._heSoQL * this._luongCB)));
        }
    }
}