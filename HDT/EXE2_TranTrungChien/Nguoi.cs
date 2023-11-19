using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2_TranTrungChien
{
    class Nguoi 
    {
        // fields
        private string _hoTen;
        private string _diaChi;
        private static int _soNguoi;

        // properties
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

        public static int SoNguoi
        {
            get
            {
                return _soNguoi;
            }

            set
            {
                _soNguoi = value;
            }
        }

        // Constructor
        public Nguoi()
        {

        }

        public Nguoi(string hoTen, string diaChi)
        {
            this._hoTen = hoTen;
            this._diaChi = diaChi;
        }

        // method
        public string toString()
        {
            return ($"Ho Ten: {this._hoTen} Dia Chi: {this._diaChi}");
        }
    }
}
