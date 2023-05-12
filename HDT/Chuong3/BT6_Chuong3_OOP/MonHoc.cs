using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_Chuong3_OOP
{
    class MonHoc
    {
        // fields
        private string _maMH;
        private string _tenMH;
        private int _soTC;
        private double _diemMH;
       


        // properties
        public string MaMH
        {
            get
            {
                return _maMH;
            }

            set
            {
                _maMH = value;
            }
        }

        public string TenMH
        {
            get
            {
                return _tenMH;
            }

            set
            {
                _tenMH = value;
            }
        }

        public int SoTC
        {
            get
            {
                return _soTC;
            }

            set
            {
                _soTC = value;
            }
        }

        public double DiemMH
        {
            get
            {
                return _diemMH;
            }

            set
            {
                _diemMH = value;
            }
        }




        // Constructor

        public MonHoc(string maMH, string tenMH, int soTC, double diemMH)
        {

            this._maMH = maMH;
            this._tenMH = tenMH;
            this._soTC = soTC;
            this._diemMH = diemMH;
        }

        // method

        public string toString()
        {
            string result = "";

            result += $"{this._maMH,-15}{this._tenMH,-15}{this._soTC,-15}{this._diemMH,-15}\n";

            return result;
        }

    }
}
