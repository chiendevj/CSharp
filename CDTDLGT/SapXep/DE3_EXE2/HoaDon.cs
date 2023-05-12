using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE3_EXE2
{
    class HoaDon
    {
        //field
        private string _maHoaDon;
        private string _tenKH;
        private DateTime _ngayThanhToan;
        private int _tienThanhToan;

        // properties
        public string MaHoaDon
        {
            get
            {
                return _maHoaDon;
            }

            set
            {
                _maHoaDon = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _tenKH;
            }

            set
            {
                _tenKH = value;
            }
        }

        public DateTime NgayThanhToan
        {
            get
            {
                return _ngayThanhToan;
            }

            set
            {
                _ngayThanhToan = value;
            }
        }

        public int TienThanhToan
        {
            get
            {
                return _tienThanhToan;
            }

            set
            {
                _tienThanhToan = value;
            }
        }

        // Contructor
        public HoaDon()
        {
            
        }

        public HoaDon(string maHoaDon, string tenKH, DateTime ngayTT, int soTienTT)
        {
            this._maHoaDon = maHoaDon;
            this._tenKH = tenKH;
            this._ngayThanhToan = ngayTT;
            this._tienThanhToan = soTienTT;
        }

        // method

        public string Display()
        {
            return($"{this._maHoaDon,-15}{this._tenKH,-15}{this._ngayThanhToan.ToString("dd/MM/yyyy"),-15}{this._tienThanhToan,-15}");
        }

    }
}
