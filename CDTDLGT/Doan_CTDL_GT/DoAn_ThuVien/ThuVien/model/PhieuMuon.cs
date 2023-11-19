using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ThuVien
{
    class PhieuMuon
    {
        // Fields
        private int _soPhieuMuon;
        private BanDoc _thongTinBanDoc;
        private Sach _thongTinSach;
        private int _tinhTrang;
        private DateTime _ngayMuonSach;
        private DateTime _ngayTraSach;


        //  Propreties
        public DateTime NgayTraSach
        {
            get
            {
                return _ngayTraSach;
            }
            set
            {
                _ngayTraSach = value;
            }
        }

        public DateTime NgayMuonSach
        {
            get
            {
                return _ngayMuonSach;
            }
            set
            {
                _ngayMuonSach = value;
            }
        }

        public int SoPhieuMuon
        {
            get
            {
                return _soPhieuMuon;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("tham so khong hop le !!! (so phieu muon phai > 0)");
                }
                _soPhieuMuon = value;
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
                if (value != 0 && value != 1)
                {
                    throw new Exception("tham so khong hop le !!! (tinh trang chi mang gia tri 0 hoac 1)");
                }
                _tinhTrang = value;
            }
        }

        public BanDoc ThongTinBanDoc
        {
            get
            {
                return _thongTinBanDoc;
            }
            set
            {
                _thongTinBanDoc = value;
            }
        }

        public Sach ThongTinSach
        {
            get
            {
                return _thongTinSach;
            }
            set
            {
                _thongTinSach = value;
            }
        }

        // Constructor
        public PhieuMuon()
        {
            this._soPhieuMuon = 0;
            this._thongTinBanDoc = new BanDoc();
            this._thongTinSach = new Sach();
            this._tinhTrang = 0;
            this._ngayMuonSach = DateTime.Now;
            this._ngayTraSach = DateTime.Now;
        }

        public PhieuMuon(int soPhieuMuon, BanDoc thongTinBanDoc, Sach thongTinSach, int tinhTrang, DateTime ngayMuonSach)
        {
            if (soPhieuMuon < 0 || (tinhTrang != 0 && tinhTrang != 1))
            {
                throw new Exception("tham so khong hop le!!! (so phieu muon phai > 0, tinh trang chi mang gia tri 0 hoac 1)");
            }
            this._soPhieuMuon = soPhieuMuon;
            this._thongTinBanDoc = thongTinBanDoc;
            this._thongTinSach = thongTinSach;
            this._tinhTrang = tinhTrang;
            this._ngayMuonSach = ngayMuonSach;
            this._ngayTraSach = ngayMuonSach.AddDays(7); // Hạn trả sách tính từ ngày mượn + thêm 7 ngày sau
        }

        public PhieuMuon(int soPhieuMuon, BanDoc thongTinBanDoc, Sach thongTinSach, int tinhTrang, DateTime ngayMuonSach, DateTime ngayTraSach)
        {
            if (soPhieuMuon < 0 || (tinhTrang != 0 && tinhTrang != 1))
            {
                throw new Exception("tham so khong hop le!!! (so phieu muon phai > 0, tinh trang chi mang gia tri 0 hoac 1)");
            }
            this._soPhieuMuon = soPhieuMuon;
            this._thongTinBanDoc = thongTinBanDoc;
            this._thongTinSach = thongTinSach;
            this._tinhTrang = tinhTrang;
            this._ngayMuonSach = ngayMuonSach;
            this._ngayTraSach = ngayTraSach;
        }
        
        // Tính số ngày trả sách qúa hạn
        public double SoNgayQuaHanTra()
        {
            DateTime hanTra = this.NgayTraSach; // Ngày hạn trả sách
            DateTime ngayTra = DateTime.Now; // Ngày trả sách

            TimeSpan soNgayVuot = ngayTra - hanTra; // Số ngày qua hạn
            return Math.Round(soNgayVuot.TotalDays, 0);
        }

        // Methods
        public string toString()  // Print to screen
        {
            return $"{_soPhieuMuon}#{_thongTinBanDoc.MaBanDoc}#{_thongTinSach.MaSach}#{_tinhTrang}#{_ngayMuonSach}#{_ngayTraSach}";
        }

        public string printFile()   // Print to files
        {
            return ($"{_soPhieuMuon}#{_thongTinBanDoc.MaBanDoc}#{_thongTinSach.MaSach}#{_tinhTrang}#{_ngayMuonSach.ToString("dd/MM/yyyy")}#{_ngayTraSach.ToString("dd/MM/yyyy")}");
        }
    }
}