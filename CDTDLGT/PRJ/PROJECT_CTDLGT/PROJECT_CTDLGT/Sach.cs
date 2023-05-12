using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PROJECT_CTDLGT
{
    class Sach
    {
        // private
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private string _nhaXB;
        private int _giaBan;
        private int _namPH;
        private int _soTrang;
        private int _ngayNhapKho;
        private static int _tinhTrangSach = 0;  //  khi sách được mượn thì tình trạng = Số thứ tự phiếu mượn, khi sách trả thì trở về = 0).

        // properties
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
        public int GiaBan
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
        public int NamPH
        {
            get
            {
                return _namPH;
            }
            set
            {
                _namPH = value;
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
               _soTrang = value;
            } 
        }
        public int NgayNhapKho 
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
        public static int TinhTrangSach 
        { 
            get
            {
                return _tinhTrangSach;
            } 
            set
            {
                _tinhTrangSach = value;
            } 
        }

        // Contructors
        public Sach()
        {
            _tinhTrangSach++;
        }

        public Sach(string maSach, string tenSach, string tacGia, string nhaXb, int giaBan, int namPH, int page, int ngayNK)
        {
            this._maSach = maSach;
            this._tenSach = tenSach;
            this._tacGia = tacGia;
            this._namPH = namPH;
            this._nhaXB = nhaXb;
            this._giaBan = giaBan;
            this._soTrang = page;
            this._ngayNhapKho = ngayNK;
            TinhTrangSach++;
        }

        public Sach(Sach book)
        {
            this._maSach = book._maSach;
            this._tenSach = book._tenSach;
            this._tacGia = book._tacGia;
            this._namPH = book._namPH;
            this._nhaXB = book._nhaXB;
            this._giaBan = book._giaBan;
            this._soTrang = book._soTrang;
            this._ngayNhapKho = book._ngayNhapKho;
            TinhTrangSach++;
        }

        // method

       
        public void Display()
        {

        }
    }
}
