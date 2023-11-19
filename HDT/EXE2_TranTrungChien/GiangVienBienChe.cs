using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2_TranTrungChien
{
    class GiangVienBienChe : GiangVien
    {
        // fields
        private double _heSoLuong;
        private double _luongCoBan;

        // properties
        public double HeSoLuong
        {
            get
            {
                return _heSoLuong;
            }

            set
            {
                _heSoLuong = value;
            }
        }

        public double LuongCoBan
        {
            get
            {
                return _luongCoBan;
            }

            set
            {
                _luongCoBan = value;
            }
        }

        // Constructor
        public GiangVienBienChe() : base()
        {
            Nguoi.SoNguoi++;
        }

        public GiangVienBienChe(Nguoi nhanVien, double _heSoLuong, double _luongCoBan) : base(nhanVien)
        {
            this._heSoLuong = _heSoLuong;
            this._luongCoBan = _luongCoBan;
            Nguoi.SoNguoi++;
        }

        // Method

        // GetLuong()
        public override double getLuong()
        {
            return this._heSoLuong * this._luongCoBan;
        }

        public new string toString()
        {
            return ($"Giang vien bien che:{base.toString()} Luong: {getLuong()} Dong");
        }
    }
}
