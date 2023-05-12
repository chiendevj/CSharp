using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_Chuong3_OOP
{
    class BienLai : KhachHang
    {
        // field
        private int _chiSoCu;
        private int _chiSoMoi;

        // properties
        public int ChiSoCu
        {
            get
            {
                return _chiSoCu;
            }

            set
            {
                _chiSoCu = value;
            }
        }

        public int ChiSoMoi
        {
            get
            {
                return _chiSoMoi;
            }

            set
            {
                _chiSoMoi = value;
            }
        }

        // constructor
        public BienLai(string maSoCT) : base(maSoCT)
        {
            base.MSCongTo = maSoCT;
        }

        public BienLai(string hoTen, string diaChi, string maSoCt, int chiSoMoi, int chiSoCu) : base(hoTen, diaChi, maSoCt)
        {
            base.HoTen = hoTen;
            base.DiaChi = diaChi;
            base.MSCongTo = maSoCt;
            this._chiSoCu = chiSoCu;
            this._chiSoMoi = chiSoMoi;
        }

        // method
        public int getSoTienPhaiTra()
        {
            int tienPT = 0;
            if (this._chiSoMoi < this._chiSoCu)
            {
                return tienPT;
            }
            else
            {
                tienPT = (this._chiSoMoi - this._chiSoCu) * 750;
            }
            return tienPT;
        }
        public new string toString()
        {
            return ($"{base.toString()}\n\t So tien phai tra trong thang nay: {getSoTienPhaiTra()}");
        }



    }
}
