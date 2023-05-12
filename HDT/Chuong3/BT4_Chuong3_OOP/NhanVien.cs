using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT4_Chuong3_OOP
{
    public class NhanVien
    {
        // fields
        private string _hoTen;
        private DateTime _ngaySinh;
        private DiaChi _diaChi;

        // properties
        public string HoTen 
        { 
            get
            {
                return this._hoTen;
            }
            set
            {
                this._hoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return this._ngaySinh;
            }
            set
            {
                this._ngaySinh = value;
            }
        }

        public DiaChi DiaChi
        {
            get
            {
                return this._diaChi;
            }
            set
            {
                this._diaChi = value;
            }
        }

        public NhanVien() 
        {
            // rỗng
        }
        // contructers
        public NhanVien(string name, DateTime birthday, DiaChi address)
        {
            this._hoTen = name;
            this._ngaySinh = birthday;
            this._diaChi = address;
        }
    
        public NhanVien(NhanVien nv)
        {
            this._hoTen = nv.HoTen;
            this._ngaySinh = nv.NgaySinh;
            this._diaChi = nv.DiaChi;
        }
        
        // method
        public string toString()
        {
            string str = "";
            str = ($"Ho va ten: {this._hoTen}\nNgaySinh: {this._ngaySinh.ToString("dd/MM/yyyy")}\nDia Chi: {this._diaChi.toString()}");
            return str;
        }


    }
}