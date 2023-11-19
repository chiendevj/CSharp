using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_TinhDaHinh
{
    class PhanSo
    {
        //fields
        private int _tuSo;
        private int _mauSo;

        //properties
        public int TuSo
        {
            get
            {
                return _tuSo;
            }

            set
            {
                _tuSo = value;
            }
        }

        public int MauSo
        {
            get
            {
                return _mauSo;
            }

            set
            {
                _mauSo = value;
            }
        }

        // Contructor
        public PhanSo(int tuSo, int mauSo)
        {
            this._tuSo = tuSo;
            this._mauSo = mauSo;
        }

        public PhanSo(int tuSo)
        {
            this._tuSo = tuSo;
            this._mauSo = 1;
        }

        public PhanSo()
        {
            this._tuSo = 0;
            this._mauSo = 1;
        }

        // Method
        public string toString()
        {
            if (this._mauSo == 1)
            {
                return ($"{this._tuSo}");
            }

            if (this._mauSo < 0)
            {
                this._tuSo *= -1;
                this._mauSo *= -1;
                return ($"{this._tuSo}/{this._mauSo}");
            }
            return ($"{this._tuSo}/{this._mauSo}");
        }

        // Tong
        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            PhanSo resultTong = new PhanSo();
            resultTong._mauSo = p1._mauSo * p2._mauSo;
            resultTong._tuSo = (p1._tuSo * p2._mauSo) + (p1._mauSo * p2._tuSo);
            return resultTong;
        }

        // Hieu
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo resultHieu = new PhanSo();
            resultHieu._mauSo = p1._mauSo * p2._mauSo;
            resultHieu._tuSo = (p1._tuSo * p2._mauSo) - (p1._mauSo * p2._tuSo);
            return resultHieu;
        }

        // Tich
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo resultTich = new PhanSo();
            resultTich._mauSo = p1._mauSo * p2._mauSo;
            resultTich._tuSo = p1._tuSo * p2._tuSo;
            return resultTich;
        }

        // Thuong
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo resultThuong = new PhanSo();
            resultThuong._mauSo = p1._mauSo * p2._tuSo;
            resultThuong._tuSo = p1._tuSo * p2._mauSo;
            return resultThuong;
        }

        // Rút Gọn
        public PhanSo RutGon()
        {

            int a = Math.Abs(this._tuSo);
            int b = Math.Abs(this._mauSo);
            while (a * b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            int UC = a + b;
            PhanSo psrg = new PhanSo();
            psrg._tuSo = this._tuSo / UC;
            psrg._mauSo = this._mauSo / UC;
            return psrg;
        }
        // Đổi dấu
        public static PhanSo operator +(PhanSo p)
        {
            PhanSo result = new PhanSo();
            result._tuSo = p._tuSo;
            result._mauSo = p._mauSo;
            return result;

        }

        public static PhanSo operator -(PhanSo p)
        {
            PhanSo result = new PhanSo();

            result._tuSo = -p._tuSo;
            result._mauSo = p._mauSo;
            return result;

        }

        // So Sánh Phân Số

        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            if (((double)ps1._tuSo == (double)ps1._mauSo) && ((double)ps2._tuSo == (double)ps2._mauSo))
            {
                kq = true;
            }
            return kq;
        }

        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            bool kq = true;
            if (((double)ps1._tuSo == (double)ps2._tuSo) && ((double)ps1._mauSo == (double)ps2._mauSo))
            {
                kq = false;
            }
            return kq;
        }

        public static bool operator >=(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            if (((double)ps1._tuSo / (double)ps1._mauSo) >= ((double)ps2._tuSo / (double)ps2._mauSo))
            {
                kq = true;
            }
            return kq;
        }

        public static bool operator <=(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            if (((double)ps1._tuSo / (double)ps1._mauSo) <= ((double)ps2._tuSo / (double)ps2._mauSo))
            {
                kq = true;
            }
            return kq;
        }

        public static bool operator >(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            if (((double)ps1._tuSo / (double)ps1._mauSo) > ((double)ps2._tuSo / (double)ps2._mauSo))
            {
                kq = true;
            }
            return kq;
        }

        public static bool operator <(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            if (((double)ps1._tuSo / (double)ps1._mauSo) < ((double)ps2._tuSo / (double)ps2._mauSo))
            {
                kq = true;
            }
            return kq;
        }
    }
}
