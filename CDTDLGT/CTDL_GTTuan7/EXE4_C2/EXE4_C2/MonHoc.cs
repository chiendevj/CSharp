using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE4_C2
{
    class MonHoc
    {
        private string _maMH;
        private string _tenMH;
        private DateTime _ngayDK;
        private int _soTC;

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

        public DateTime NgayDK
        {
            get
            {
                return _ngayDK;
            }

            set
            {
                _ngayDK = value;
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

        public MonHoc(string maMH, string tenMH, DateTime ngayDK, int soTC)
        {
            this._maMH = maMH;
            this._tenMH = tenMH;
            this._ngayDK = ngayDK;
            this._soTC = soTC;
        }

        public string toString()
        {
            return ($"{this._maMH,-15}{this._tenMH,-15}{this._ngayDK.ToString("d/M/yyyy"),-15}{"",-3}{this._soTC,-15}");
        }

    }
}
