using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap2
{
    public class Date
    {
        // field
        private int _ngay;
        private int _thang;
        private int _nam;


        // properties
        public int Ngay { get => _ngay; set => _ngay = value; }
        public int Thang { get => _thang; set => _thang = value; }
        public int Nam { get => _nam; set => _nam = value; }

        // constructor
        public Date()
        {
            _ngay = 1;
            _thang = 1;
            _nam = 1;
        }
        public Date(int ngay, int thang, int nam)
        {
            _ngay = ngay;
            _thang = thang;
            _nam = nam;
        }

        // METHOD

        public string XuatThongTin()
        {
            return ($"{this._ngay:00}/{this._thang:00}/{this._nam:0000}");
        }

        public static bool operator ==(Date a, Date b)
        {
            return ((a._ngay == b._ngay) && (a._thang == b._thang) && (a._nam == b._nam));
        }

        public static bool operator !=(Date a, Date b)
        {
            return (!(a._ngay == b._ngay) && (a._thang == b._thang) && (a._nam == b._nam));
        }

    }
}