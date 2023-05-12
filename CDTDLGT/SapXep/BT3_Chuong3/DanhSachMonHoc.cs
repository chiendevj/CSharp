using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Chuong3
{
    class DanhSachMonHoc
    {
        // fields
        private string _maMon;
        private string _tenMon;
        private int _soTC;
        private double _diem;
       

        // properties
        public string MaMon
        {
            get
            {
                return _maMon;
            }

            set
            {
                _maMon = value;
            }
        }

        public int SoTC
        {
            get
            {
                return _soTC;
            }

            set
            {
                _soTC = value;
            }
        }

        public double Diem
        {
            get
            {
                return _diem;
            }

            set
            {
                _diem = value;
            }
        }

        public string TenMon
        {
            get
            {
                return _tenMon;
            }

            set
            {
                _tenMon = value;
            }
        }
        // Method
        public void NhapMH()
        {
            Console.Write("\t\tNhap Ma MH: ");
            this._maMon = Console.ReadLine();
            Console.Write("\t\tNhap ten MH: ");
            this._tenMon = Console.ReadLine();
            Console.Write("\t\tNhap so TC: ");
            this._soTC = int.Parse(Console.ReadLine());
            Console.Write("\t\tNhap diem: ");
            this._diem = double.Parse(Console.ReadLine());
        }

        public void XuatMH()
        {
            Console.WriteLine($"|{this._maMon, -10}|{this._tenMon,-10}|{this._soTC,-10}|{this._diem,-10}|");
        }



    }
}
