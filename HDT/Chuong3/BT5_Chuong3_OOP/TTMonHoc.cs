using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Chuong3_OOP
{
    class TTMonHoc
    {
        // fields
        private string _tenMH;
        private int _soTC;
        private double _diem;

        // properties
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

        public double Diem
        {
            get
            {
                return _diem;
            }

            set
            {
                _diem = value;
            }
        }

        // Constructor
        public TTMonHoc(string tenMH, int soTC, double diem)
        {
            this._tenMH = tenMH;
            this._soTC = soTC;
            this._diem = diem;
        }

        // method
        
        public string toString()
        {
            
            return ($"|{this._tenMH,-20}|{this._soTC,-20}|{this._diem,-20}|");
        }

    }
}
