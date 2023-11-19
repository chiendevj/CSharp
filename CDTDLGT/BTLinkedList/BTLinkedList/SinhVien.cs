using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinkedList
{
    class SinhVien
    {
        // fields
        private string maSV, hoTen, lop;
        private DateTime ngaySinh;
        private double diemTB;

        // properties
        public string MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public double DiemTB
        {
            get
            {
                return diemTB;
            }

            set
            {
                diemTB = value;
            }
        }

        //constructor
        public SinhVien()
        {
            
        }

        public SinhVien(string maSV, string hoTen, string lop, DateTime ngaySinh, double diemTB)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.lop = lop;
            this.ngaySinh = ngaySinh;
            this.diemTB = diemTB;
        }

        // method
        public string toString()
        {
            return ($"{this.maSV,-15}{this.hoTen,-15}{this.lop,-15}{this.ngaySinh.ToString("dd/MM/yyyy"),-15}{this.diemTB,-15}");
        }

        public void Nhap()
        {
            Console.Write("Nhap Ma SV:");
            this.maSV = Console.ReadLine();
            Console.Write("Nhap ho ten SV:");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap lop:");
            this.lop = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            DateTime.TryParse(Console.ReadLine(), out this.ngaySinh);
            Console.Write("Nhap diem TB: ");
            this.diemTB = double.Parse(Console.ReadLine());
            
        }
    }
}
