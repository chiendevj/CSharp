using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap2
{
    public abstract class Nguoi
    {
        // fields
        private string _ten;
        private Date _ngaySinh = new Date();
        private string _soDT;
        private string _diaChi;

        // properties
        public string Ten { get => _ten; set => _ten = value; }
        public Date NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string SoDT { get => _soDT; set => _soDT = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }

        // constructor
        public Nguoi(string ten, Date ngaySinh, string soDT, string diaChi)
        {
            _ten = ten;
            _ngaySinh = ngaySinh;
            _soDT = soDT;
            _diaChi = diaChi;
        }

        public Nguoi()
        {
            _ten = "";
            _ngaySinh = new Date();
            _soDT = "";
            _diaChi = "";
        }

        // METHOD
        // ham in thong tin
        public virtual string ThongTin()
        {
            return ($"{this._ten}#{this._ngaySinh.XuatThongTin()}#{this._soDT}#{this._diaChi}");
        }

        // ham tinh luong
        public abstract double TinhLuong();
        
    }
}