using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
{
    public class XeTaxi:XeHoi
    {
        // fields
        private int _Socho;
        private double _GiaKM;


        // properties
        public int Socho { get => _Socho; set => _Socho = value; }
        public double GiaKM { get => _GiaKM; set => _GiaKM = value; }


        // constructor
        public XeTaxi(string mauxe, Date namSX, string nuocSX, string hieuxe, int socho, double giaKM) :base(mauxe, namSX, nuocSX, hieuxe)
        {
            _Socho = socho;
            _GiaKM = giaKM;
        }

        public XeTaxi():base()
        {
            _Socho = 0;
            _GiaKM = 0d;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._Socho}#{this._GiaKM}");
        }

        public override double TongTien()
        {
            return (this._Socho > 15) ? (this._Socho * this._GiaKM) * (100 - 10) / 100 : (this._Socho * this._GiaKM);
        }

    }
}