using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
{
    public class XeKhach:XeHoi
    {
        // field
        private int _soGhe;
        private double _giaVe;



        // properties
        public int SoGhe { get => _soGhe; set => _soGhe = value; }
        public double GiaVe { get => _giaVe; set => _giaVe = value; }

        // constructor
        public XeKhach() :base() 
        {
            _soGhe = 0;
            _giaVe = 0d;
        }
        public XeKhach(string mauxe, Date namSX, string nuocSX, string hieuxe,int soGhe, double giaVe) :base(mauxe, namSX, nuocSX, hieuxe)
        {
            _soGhe = soGhe;
            _giaVe = giaVe;
        }

        // method
        public override string ThongTin()
        {
            return ($"{base.ThongTin()}#{this._soGhe}#{this._giaVe}");
        }

        public override double TongTien()
        {
            return (this._soGhe * this.GiaVe);
        }

    }
}