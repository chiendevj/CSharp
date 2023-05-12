using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT4_Chuong3_OOP
{
    public class NVVanPhong : NhanVien
    {
        // fields
        private double _luong;
        private int _soNgayLV;

        // properties
        public double Luong
        {
            get
            {
                return this._luong;
            }

            set
            {
                this._luong = value;
            }
        }
        public int SoNgayLV
        {
            get
            {
                return this._soNgayLV;
            }
            set
            {
                this._soNgayLV = value;
            }
        }

        // Constructor

        public NVVanPhong() : base()
        {

        }

        public NVVanPhong(double luongCB, int soNgayLV, string name, DateTime ngaySinh, DiaChi diaChi) : base(name, ngaySinh, diaChi)
        {
            this._luong = luongCB;
            this._soNgayLV = soNgayLV;
            base.HoTen = name;
            base.NgaySinh = ngaySinh;
            base.DiaChi = diaChi;
        }

        // method
        public double getLuong()
        {
            double luong = 0;
            luong = this._soNgayLV * 100000;
            return luong;
        }

        public new string toString()
        {
            string str = "";
            str = ($"{base.toString()} Luong NVVP: {this.getLuong()}");
            return str;
        }




    }

}