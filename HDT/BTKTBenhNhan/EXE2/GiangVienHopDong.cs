using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2
{
    class GiangVienHopDong : GiangVien
    {
        // fields
        private double _giaTien1Tiet;
        private int _soTietGiang;

        //properties

        public double GiaTien1Tiet
        {
            get
            {
                return _giaTien1Tiet;
            }

            set
            {
                _giaTien1Tiet = value;
            }
        }

        public int SoTietGiang
        {
            get
            {
                return _soTietGiang;
            }

            set
            {
                _soTietGiang = value;
            }
        }

        // Constructor
        public GiangVienHopDong(Nguoi nhanVien, double _giaTien1Tiet, int _soTietGiang) : base(nhanVien)
        {
            this._giaTien1Tiet = _giaTien1Tiet;
            this._soTietGiang = _soTietGiang;
            Nguoi.SoNguoi++;
        }

        public GiangVienHopDong() : base()
        {
            Nguoi.SoNguoi++;
        }

        // Method
        // getLuong()
        public override double getLuong()
        {
            return this._giaTien1Tiet * this._soTietGiang;
        }

        public override string toString()
        {
            return ($"giang vien hop dong: Ho ten: {base.ThongTinNV.HoTen} Dia Chi: {base.ThongTinNV.DiaChi} Luong: {getLuong()} Dong.");
        }
    }

}
