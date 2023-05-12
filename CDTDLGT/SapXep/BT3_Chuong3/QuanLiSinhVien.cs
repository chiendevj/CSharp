using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Chuong3
{
    class QuanLiSinhVien
    {
        private string _maSV;
        private string _hoTen;
        private DateTime _ngaySinh;
        private int _soMonHoc;
        private DanhSachMonHoc[] arrMH;

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

        public DateTime NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public int SoMonHoc
        {
            get
            {
                return _soMonHoc;
            }

            set
            {
                _soMonHoc = value;
            }
        }

        public DanhSachMonHoc[] ArrMH
        {
            get
            {
                return arrMH;
            }

            set
            {
                arrMH = value;
            }
        }

        public void NhapSV()
        {
            Console.Write("\tMa SV: ");
            this._maSV = Console.ReadLine();
            Console.Write("\tHo va ten: ");
            this._hoTen = Console.ReadLine();
            Console.Write("\tNgay sinh: ");
            DateTime.TryParse(Console.ReadLine(), out this._ngaySinh);
            Console.Write("So mon hoc: ");
            this._soMonHoc = int.Parse(Console.ReadLine());
            arrMH = new DanhSachMonHoc[this._soMonHoc];
            for (int i = 0; i < arrMH.Length; i++)
            {
                DanhSachMonHoc ds = new DanhSachMonHoc();
                ds.NhapMH();
                arrMH[i] = ds;
            }
        }

        public void XuatSV()
        {
            Console.WriteLine($"{"MaSV:",-15}{this._maSV,-15}");
            Console.WriteLine($"{"Ho ten:",-15}{this._hoTen,-15}");
            Console.WriteLine($"{"Ngay sinh:",-15}{this._ngaySinh.ToString("dd/MM/yyyy"),-15}");
            Console.WriteLine($"Danh sach {this._soMonHoc} mon hoc da hoc:");
            Console.WriteLine($"|{"MaMH",-10}|{"TenMH",-10}|{"So TC",-10}|{"DTB",-10}|");
            for (int i = 0; i < arrMH.Length; i++)
            {
                arrMH[i].XuatMH();
            }
            Console.WriteLine("******************************");
        }
    }
}
