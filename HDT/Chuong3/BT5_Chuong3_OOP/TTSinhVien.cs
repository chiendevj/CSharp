using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Chuong3_OOP
{
    class TTSinhVien : TTLopHoc
    {
        // fields
        private string _maSV;
        private string _hoTen;
        private TTMonHoc[] ttMH;

        // properties
        public string MaSV
        {
            get
            {
                return _maSV;
            }

            set
            {
                _maSV = value;
            }
        }

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

        internal TTMonHoc[] TtMH
        {
            get
            {
                return ttMH;
            }

            set
            {
                ttMH = value;
            }
        }


        // Constuctor

        public TTSinhVien(string lop, string khoa) : base(lop, khoa)
        {
            base.TenLop = lop;
            base.Khoa = khoa;
        }

        public TTSinhVien(string lop, string khoa, string maSV, string hoTen, TTMonHoc[] ttMH) :base(lop, khoa)
        {
            base.TenLop = lop;
            base.Khoa = khoa;
            this._maSV = maSV;
            this._hoTen = hoTen;
            this.TtMH = ttMH;
        }

        // method
        public new string toString()
        {
            string result= ($"\tPHIEU BAO DIEM\n\tMa sinh vien: {this._maSV,-20}Ten sinh vien: {this._hoTen}\n\t{base.toString()}\n\n{"",30} BANG DIEM\n");
            result += ("+--------------------+--------------------+--------------------+\n");
            result += ($"|{"Ten Mon",-20}|{"So tin chi",-20}|{"Diem",-20}|\n");
            result += ("+--------------------+--------------------+--------------------+\n");
            for (int i = 0; i < this.ttMH.Length; i++)
            {
                result += this.ttMH[i].toString() +"\n";
            }
            result += ("+--------------------+--------------------+--------------------+");
            return result;
        }
         
    }
}
