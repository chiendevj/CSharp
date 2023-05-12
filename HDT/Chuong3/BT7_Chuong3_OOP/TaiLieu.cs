using System;
using System.IO;

namespace BT7_Chuong3_OOP
{
    internal class TaiLieu
    {
        // fields
        private string _maTaiLieu;
        private string _loaiTaiLieu;
        private string _tenTaiLieu;
        private string _tacGia;
        private string _nhaXB;
        private string _ghiChu;

        // properties
        public string MaTaiLieu
        {
            get
            {
               return _maTaiLieu;
            }
            set 
            {
                _maTaiLieu = value;
            } 
        }
        public string LoaiTaiLieu
        {
            get
            {
                return _loaiTaiLieu;
            }
            set
            {
                _loaiTaiLieu = value;
            }
        }
        public string TenTaiLieu
        {
            get
            {
                return _tenTaiLieu;
            }
            set
            {
                _tenTaiLieu = value;
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
        public string GhiChu 
        { 
            get
            {
                return _ghiChu;
            }
            set
            {
                _ghiChu = value;
            } 
        }

        // Contructors
        public TaiLieu()
        {

        }

        public TaiLieu(string maTL, string loaiTL, string tenTL, string tacGia, string nhaXB, string ghiChu)
        {
            this._maTaiLieu = maTL;
            this._loaiTaiLieu = loaiTL;
            this._tenTaiLieu= tenTL;
            this._tacGia= tacGia;
            this._nhaXB= nhaXB;
            this._ghiChu= ghiChu;
        }

        public TaiLieu(TaiLieu doc)
        {
            this._maTaiLieu = doc._maTaiLieu;
            this._loaiTaiLieu = doc._loaiTaiLieu;
            this._tenTaiLieu = doc._tenTaiLieu;
            this._tacGia = doc._tacGia;
            this._nhaXB = doc._nhaXB;
            this._ghiChu = doc._ghiChu;
        }

        // Method
        public string toString()
        {
            string s = "";
            s = ($"|{this._maTaiLieu, -10}|{this._loaiTaiLieu,-15}|{this._tenTaiLieu,-20}|{this._tacGia,-20}|{this._nhaXB,-15}|{this._ghiChu,-10}|");
            return s;
        }
        
    }
}
