using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Chuong3_OOP
{
    class KhachHang
    {
        private string _hoTen;
        private string _diaChi;
        private string _mSCongTo;

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public string MSCongTo
        {
            get
            {
                return _mSCongTo;
            }

            set
            {
                _mSCongTo = value;
            }
        }

        public KhachHang(string maSoCT)
        {
            this._mSCongTo = "";
        }

        public KhachHang(string hoTen, string diaChi, string maSoCT)
        {
            this._hoTen = hoTen;
            this._diaChi = diaChi;
            this._mSCongTo = maSoCT;
        }

        public string toString()
        {
            return ($"Ho va ten: {this._hoTen}\n Dia Chi: {this._diaChi}\nMa So CT; {this._mSCongTo}");
        }

    }
}
