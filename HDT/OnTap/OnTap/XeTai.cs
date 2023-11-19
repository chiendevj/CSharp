using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
{
    public class XeTai:XeHoi
    {
        // fields
        private int _Trongtai;
        private int _SoKM;
        private double _Dongia;

        // properties
        public int Trongtai { get => _Trongtai; set => _Trongtai = value; }
        public int SoKM { get => _SoKM; set => _SoKM = value; }
        public double Dongia { get => _Dongia; set => _Dongia = value; }

       // constructor
        public XeTai(string mauxe, Date namSX, string nuocSX, string hieuxe,int trongtai, int soKM, double dongia): base(mauxe, namSX, nuocSX, hieuxe)
        {
            _Trongtai = trongtai;
            _SoKM = soKM;
            _Dongia = dongia;
        }

        public XeTai() : base()
        {
            _Trongtai = 0;
            _SoKM = 0;
            _Dongia = 0d;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._Trongtai}#{this._SoKM}#{this._Dongia}");
        }

        public override double TongTien()
        {
            return (this._SoKM > 30) ? (this._SoKM * this._Dongia) * (100 - 5) / 100 : (this._SoKM * this._Dongia);
        }
    }
}