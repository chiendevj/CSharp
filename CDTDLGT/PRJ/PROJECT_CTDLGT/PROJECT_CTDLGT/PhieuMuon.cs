using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_CTDLGT
{
    class PhieuMuon 
    {
        // fields
        private Sach _maSach;
        private int _soPhieuMuon;
        private string _maBanDoc;
        private DateTime _ngayMuon;
        private static int _tinhTrangPM = 0;
        private static int _soThuTuPM = 0;

        // Properties
        public int SoPhieuMuon
        {
            get 
            { 
                return _soPhieuMuon; 
            }
            set 
            { 
                _soPhieuMuon = value; 
            }
        }

        public string MaBanDoc
        {
            get 
            { 
                return _maBanDoc; 
            }
            set 
            { 
                _maBanDoc = value; 
            }
        }

        public DateTime NgayMuon
        {
            get 
            { 
                return _ngayMuon;
            }

            set
            {
                _ngayMuon = value;
            }
        }

        public static int TinhTrangPM 
        {
            get
            {
                return _tinhTrangPM;
            } 
            set
            {
                _tinhTrangPM = value;
            }
        }
        public static int SoThuTuPM 
        { 
            get
            {
                return _soThuTuPM;
            } 
            set
            {
                _soThuTuPM = value;
            } 
        }

        internal Sach MaSach 
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

        // Contructors
        public PhieuMuon() : base()
        {
            TinhTrangPM++;
            SoThuTuPM++;
        }
    
        public PhieuMuon(int soPhieuMuon, string maBanDoc, DateTime ngayMuon, Sach maSach) 
        {
            this._soPhieuMuon = soPhieuMuon;
            this._maBanDoc = maBanDoc;
            this._ngayMuon = ngayMuon;
            this.MaSach = maSach;
            TinhTrangPM++;
            SoThuTuPM++;
        }
    

    
    
    }
}
