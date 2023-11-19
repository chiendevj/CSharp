using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
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
            this._ngay = 1;
            this._thang = 1;
            this._nam = 1;
        }

        public Date(int ngay, int thang, int nam)
        {
            _ngay = ngay;
            _thang = thang;
            _nam = nam;
        }

        // method
        public override string ToString()
        {
            return ($"{this._ngay:00}/{this._thang:00}/{this._nam:0000}");
        }

        private string PrintDate() 
        {
            return ($"{this._ngay:00}/{this._thang:00}/{this._nam:00}");
        }

        public static bool operator ==(Date d1, Date d2)
        {
            return ((d1._ngay == d2._ngay) && (d1._thang == d2._thang) && (d1._nam == d2._nam));
        }

        public static bool operator !=(Date d1, Date d2)
        {
            return (!(d1._ngay == d2._ngay) && (d1._thang == d2._thang) && (d1._nam == d2._nam));
        }


    }
}