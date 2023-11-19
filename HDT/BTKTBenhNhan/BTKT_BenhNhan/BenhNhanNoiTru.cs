using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT_BenhNhan
{
    internal class BenhNhanNoiTru : BenhNhan
    {
        // fields
        private DateTime _ngayNhapVien;
        private DateTime _ngayRaVien;
        private string _tenKhoa;
        private int _soGiuong;

       
        // fields
        public DateTime NgayNhapVien { get => _ngayNhapVien; set => _ngayNhapVien = value; }
        public DateTime NgayRaVien { get => _ngayRaVien; set => _ngayRaVien = value; }
        public string TenKhoa { get => _tenKhoa; set => _tenKhoa = value; }
        public int SoGiuong { get => _soGiuong; set => _soGiuong = value; }

        // constructor

        public BenhNhanNoiTru() : base()
        {
            BenhNhan.SoLuongBenhNhan++;
        }

        public BenhNhanNoiTru(string maHS, string hoTen, DateTime ngSinh, string chuanDBN, DateTime ngayLHS, DateTime ngayNhapVien, DateTime ngayRaVien, string tenKhoa, int soGiuong) : base(maHS, hoTen,ngSinh, chuanDBN, ngayLHS)
        {
            this._ngayNhapVien = ngayNhapVien;
            this._ngayRaVien = ngayRaVien;
            this._tenKhoa = tenKhoa;
            this._soGiuong = soGiuong;
            BenhNhan.SoLuongBenhNhan++;
        }

        public BenhNhanNoiTru(BenhNhan bn, DateTime ngayNhapVien, DateTime ngayRaVien, string tenKhoa, int soGiuong) : base(bn)
        {
            this._ngayNhapVien = ngayNhapVien;
            this._ngayRaVien = ngayRaVien;
            this._tenKhoa = tenKhoa;
            this._soGiuong = soGiuong;
            BenhNhan.SoLuongBenhNhan++;
        }
        // Method
        public override string toString()
        {
            return ($"Ma Ho So:{this.MaHoSo,-15}\nHo ten:{this.HoTen,-15}\nNgay sinh:{this.NgaySinh.ToString("dd/MM/yyyy"),-15}\nChuan doan benh:{this.ChuanDoanBenh,-15}\nNgay Lap Ho So:{this.NgayLapHoSo.ToString("dd/MM/yyyy"),-15}\n{"",-5}Ngay Nhap Vien:{this._ngayNhapVien.ToString("dd/MM/yyyy"),10}\n{"",-5}Ngay Ra Vien:{this._ngayRaVien.ToString("dd/MM/yyyy"),10}\n{"",-5}Ten Khoa:{this._tenKhoa,10}\n{"",-5}SoGiuong:{this._soGiuong,10}\n{"",-5}Benh Nhan thu{SoLuongBenhNhan}");
        }
    }
}
