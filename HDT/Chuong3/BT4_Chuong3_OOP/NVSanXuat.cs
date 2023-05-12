using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT4_Chuong3_OOP
{
    public class NVSanXuat : NhanVien
    {
        // field
        private double _luongCB;
        private int _soSanPham;

        // properties
        public void SetLuongCB(double value)
        {
            _luongCB = value;
        }

        public double GetLuongCB()
        {
            return _luongCB;
        }

        public int GetSoSanPham()
        {
            return _soSanPham;
        }

        public void SetSoSanPham(int value)
        {
            _soSanPham = value;
        }

        // Contructers
        public NVSanXuat(int soSanPham) : base()
        {
            this.SetSoSanPham(0);
            this.SetLuongCB(0);
            SetSoSanPham(soSanPham);
        }

        public NVSanXuat(double luongCB, int soSanPham, string name, DateTime ngaySinh, DiaChi diaChi) : base(name, ngaySinh, diaChi)
        {
            this.SetLuongCB(luongCB);
            this.SetSoSanPham(soSanPham);
            base.HoTen = name;
            base.NgaySinh = ngaySinh;
            base.DiaChi = diaChi;
            
        }

       
        // method
        public double getLuong()
        {
            double luongSX = 0;
            luongSX = this.GetLuongCB() + this.GetSoSanPham() * 5000;
            return luongSX;
        }
    
        public new string toString()
        {
            string result = "";
            result = ($"{base.toString()}\n\tLuong NVSX: {getLuong()}");
            return result;
        }
    }
}