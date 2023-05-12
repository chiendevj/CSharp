using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT4_Chuong3_OOP
{
    public class DiaChi 
    {
        // fields
        private string _soNha;
        private string _tenDuong;
        private string _tenQuan;
        private string _tenThanhPho;

        // properties
        public string SoNha { get => _soNha; set => _soNha = value; }
        public string TenDuong { get => _tenDuong; set => _tenDuong = value; }
        public string TenQuan { get => _tenQuan; set => _tenQuan = value; }
        public string TenThanhPho { get => _tenThanhPho; set => _tenThanhPho = value; }

        // Contructers
        public DiaChi()
        {
           
        }

        public DiaChi(string soNha, string tenDuong, string tenQuan, string tenThanhPho)
        {
            this._soNha = soNha;
            this._tenDuong = tenDuong;
            this._tenQuan = tenQuan;
            this._tenThanhPho = tenThanhPho;
        }

        // method

        public string toString()
        {
            return ($"\n\tSo nha: {this._soNha}\n\tTen Duong: {this._tenDuong}\n\tTen Quan: {this._tenQuan}\n\tTen Thanh Pho: {this._tenThanhPho}");
        }
    }
}