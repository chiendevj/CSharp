using System;
using System.IO;

namespace BT6_Chuong3_OOP
{
    class SinhVien
    {
        // field
        private string _maSV;
        private string _hoTen;
        private int _namSinh;
        private MonHoc[] _monHocs;

        // properties
        public string MaSV
        {
            get
            {
                return _maSV;
            }

            set
            {
                _maSV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return _namSinh;
            }

            set
            {
                _namSinh = value;
            }
        }

        public MonHoc[] MonHocs
        {
            get
            {
                return _monHocs;
            }

            set
            {
                _monHocs = value;
            }
        }

        // Constructor
        public SinhVien()
        {

        }

        public SinhVien(string maSV, string hoTen, int namSinh, MonHoc[] arr)
        {
            this._maSV = maSV;
            this._hoTen = hoTen;
            this._namSinh = namSinh;
            this._monHocs = arr;
        }

        // method
        
        

        // DIEM TB
        public double DiemTrungBinh()
        {
            double tongDiem = 0;
            int tongSoTinChi = 0;
            foreach (var item in this._monHocs)
            {
                tongDiem += item.DiemMH * item.SoTC;
                tongSoTinChi += item.SoTC;
            }
            double diemTB = tongDiem / tongSoTinChi;
            return diemTB;
        }

        // XEP LOAI
        public string XepLoai()
        {
            double diemTb = DiemTrungBinh();
            if (diemTb < 10 && diemTb >= 9)
            {
                return "Xep Loai: Xuat sac.";
            }
            else if (diemTb >= 8)
            {
                return "Xep Loai: Gioi.";
            }
            else if (diemTb >= 7)
            {
                return "Xep Loai:  Kha.";
            }
            else if (diemTb >= 5)
            {
                return "Xep Loai: Trung Binh.";
            }
            return "Xep Loai: Yeu.";
        }
        public string toString()
        {
            string result = "";
            result += "************************************************************\n";
            result += ($"MaSV: {this._maSV}\nHo ten: {this._hoTen}\nNam sinh: {this._namSinh}\n");
            result += "************************************************************\n";
            result += $"Danh sach gom {this.MonHocs.Length} mon hoc: \n";
            result += ($"{"STT",-5}{"Ma Mon",-15}{"Ten Mon",-15}{"So Tin Chi",-15}{"Diem",-15}\n");
            for (int i = 0; i < this.MonHocs.Length; i++)
            {
                result += $"{i + 1, -5}";
                result += this.MonHocs[i].toString();
            }

            // DIEM TB
            result += $"Diem trung binh tich luy: {Math.Round(this.DiemTrungBinh(), 2)}\n";

            // XEP LOAI
            result += $"{XepLoai()}\n";
            result += "************************************************************\n";

            return result;

        }

    }
}
