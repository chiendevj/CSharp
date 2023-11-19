using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    class HangHoa
    {
        // fields
        private string _maHang;
        private string _tenHang;
        private int _soLuong;
        private double _donGia;

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

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public double DonGia
        {
            get
            {
                return _donGia;
            }

            set
            {
                _donGia = value;
            }
        }

        public HangHoa()
        {
            
        }

        public HangHoa(string _maHang, string _tenHang, int _soLuong, double _donGia)
        {
            this.MaHang = _maHang;
            this.TenHang = _tenHang;
            this.SoLuong = _soLuong;
            this.DonGia = _donGia;
        }

        // Method
        public new string ToString()
        {
            return ($"{this.MaHang,-15}|{this.TenHang,-15}|{this.SoLuong,-15}|{this.DonGia,-15}");
        }
    }
}
