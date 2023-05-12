using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EXE2_D4
{
    class QuanLiNhanVien
    {
        //fields
        private string _maNV;
        private string _hoTen;
        private DateTime _ngaySinh;
        private double _luong;

        // properties
        public string MaNV 
        { 
            get
            {
                return this._maNV;
            }  
            set
            {
                this._maNV = value; 
            } 
        }

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

        // constructor
        public QuanLiNhanVien(string maNV, string hoTen, DateTime ngaySinh, double luong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Luong = luong;
        }

        // method

        public string toString()
        {
            return ($"|{this._maNV,-15}|{this._hoTen,-15}|{this._ngaySinh.ToString("MM/dd/yyyy"),-15}|{this._luong,-12}|");
        }
    }    
}
