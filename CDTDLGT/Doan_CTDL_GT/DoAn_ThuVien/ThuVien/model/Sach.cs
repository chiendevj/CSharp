using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    class Sach
    {
        // Fields
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private string _nhaXB;
        private double _giaBan;
        private int _namPhatHanh;
        private int _soTrang;
        private DateTime _ngayNhapKho;
        private int _tinhTrang;

        // Properties
        public string MaSach
        {
            get
            {
                return _maSach;
            }
            set
            {
                _maSach = value;
            }
        }
        public string TenSach
        {
            get
            {
                return _tenSach;
            }

            set
            {
                _tenSach = value;
            }
        }
        public string TacGia
        {
            get
            {
                return _tacGia;
            }

            set
            {
                _tacGia = value;
            }
        }
        public string NhaXB
        {
            get
            {
                return _nhaXB;
            }
            set
            {
                _nhaXB = value;
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
                if (value < 0)
                {
                    throw new Exception("tham so khong hop le!!! (gia ban phai > 0)");
                }
                _giaBan = value;
            }
        }
        public int NamPhatHanh
        {
            get
            {
                return _namPhatHanh;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("tham so khong hop le!!! (nam phat hanh phai > 0)");
                }
                _namPhatHanh = value;
            }
        }
        public int SoTrang
        {
            get
            {
                return _soTrang;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("tham so khong hop le!!! (so trang phai > 0)");
                }
                _soTrang = value;
            }
        }
        public DateTime NgayNhapKho
        {
            get
            {
                return _ngayNhapKho;
            }
            set
            {
                _ngayNhapKho = value;
            }
        }
        public int TinhTrang
        {
            get
            {
                return _tinhTrang;
            }
            set
            {
                _tinhTrang = value;
            }
        }

        // Constructors
        public Sach()
        {
            this._maSach = "unknown";
            this._tenSach = "unknown";
            this._tacGia = "unknown";
            this._nhaXB = "unknown";
            this._giaBan = 0;
            this._namPhatHanh = 0;
            this._soTrang = 0;
            this._ngayNhapKho = DateTime.Now;
            this._tinhTrang = 0;
        }
        public Sach(string maSach, string tenSach, string tacGia, string nhaXB, double giaBan, int namPhatHanh, int soTrang, DateTime ngayNhapKho, int tinhTrang)
        {
            if (soTrang < 0)
            {
                throw new Exception("tham so khong hop le!!! (so trang phai > 0)");
            }

            if (namPhatHanh < 0)
            {
                throw new Exception("tham so khong hop le!!! (nam phat hanh phai > 0)");
            }
            this._maSach = maSach;
            this._tenSach = tenSach;
            this._tacGia = tacGia;
            this._nhaXB = nhaXB;
            this._giaBan = giaBan;
            this._namPhatHanh = namPhatHanh;
            this._soTrang = soTrang;
            this._ngayNhapKho = ngayNhapKho;
            this._tinhTrang = tinhTrang;
        }

        // Methods

        // Hàm in thông tin sách theo bảng
        public string toString()
        {
            return ($"|{_maSach,-10}|{_tenSach,-25}|{_tacGia,-20}|{_nhaXB,-20}|{_giaBan,-10}|{_namPhatHanh,-10}|{_soTrang,-10}|{_ngayNhapKho.ToString("dd/MM/yyyy"),-20}|{_tinhTrang,5}{"",-5}|");
        }

        // Hàm lấy thông tin ghi vào file
        public string printFile()
        {
            return ($"{_maSach}#{_tenSach}#{_tacGia}#{_nhaXB}#{_giaBan}#{_namPhatHanh}#{_soTrang}#{_ngayNhapKho.ToString("dd/MM/yyyy")}#{_tinhTrang}");
        }


    }
}