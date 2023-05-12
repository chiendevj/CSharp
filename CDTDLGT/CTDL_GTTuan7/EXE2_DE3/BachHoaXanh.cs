using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2_DE3
{
    class BachHoaXanh
    {
        // fields
        private string _maHang;
        private string _tenHang;
        private DateTime _ngayNK;
        private double _giaBan;

        // properties
        public string MaHang
        {
            get
            {
                return _maHang;
            }

            set
            {
                _maHang = value;
            }
        }

        public string TenHang
        {
            get
            {
                return _tenHang;
            }

            set
            {
                _tenHang = value;
            }
        }

        public DateTime NgayNK
        {
            get
            {
                return _ngayNK;
            }

            set
            {
                _ngayNK = value;
            }
        }

        public double GiaBan
        {
            get
            {
                return _giaBan;
            }

            set
            {
                _giaBan = value;
            }
        }

        // Constructor
        public BachHoaXanh(string maHang, string tenHang, DateTime ngayNK, double giaBan)
        {
            this._maHang = maHang;
            this._tenHang = tenHang;
            this._ngayNK = ngayNK;
            this._giaBan = giaBan;
        }

        // method

        public string toString()
        {
            return ($"|{"",-5}{this._maHang,-10}|{"", -6}{this._tenHang,-9}|{"",-2}{this._ngayNK.ToString("d/M/yyyy"),-13}|{"",-4}{this._giaBan,-8}|");
        }

    }
}
