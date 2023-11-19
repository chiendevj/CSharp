using System;

namespace BTKT_BenhNhan
{
    internal class BenhNhanNgoaiTru : BenhNhan
    {
        // fields
        private DateTime _ngayKham;
        private string _maSoBaoHiem;
        private string _maToaThuoc;

        // properties
        public DateTime NgayKham { get => _ngayKham; set => _ngayKham = value; }
        public string MaSoBaoHiem { get => _maSoBaoHiem; set => _maSoBaoHiem = value; }
        public string MaToaThuoc { get => _maToaThuoc; set => _maToaThuoc = value; }

        // constructor
        public BenhNhanNgoaiTru() : base() 
        {
            SoLuongBenhNhan++;
        }

        public BenhNhanNgoaiTru(string maHS, string hoTen, DateTime ngSinh, string chuanDBN, DateTime ngayLHS, DateTime ngayKham, string maSoBaoHiem, string maToaThuoc)  : base(maHS, hoTen , ngSinh ,chuanDBN ,ngayLHS ) 
        {
            _ngayKham = ngayKham;
            _maSoBaoHiem = maSoBaoHiem;
            _maToaThuoc = maToaThuoc;
            SoLuongBenhNhan++;
        }

        public BenhNhanNgoaiTru(BenhNhan bn, DateTime ngayKham, string maSoBaoHiem, string maToaThuoc) : base(bn)
        {
            _ngayKham = ngayKham;
            _maSoBaoHiem = maSoBaoHiem;
            _maToaThuoc = maToaThuoc;
            SoLuongBenhNhan++;
        }

        // Method
        public override string toString()
        {
            return ($"Ma Ho So:{this.MaHoSo,-15}\nHo ten:{this.HoTen,-15}\nNgay sinh:{this.NgaySinh.ToString("dd/MM/yyyy"),-15}\nChuan doan benh:{this.ChuanDoanBenh,-15}\nNgay Lap Ho So:{this.NgayLapHoSo.ToString("dd/MM/yyyy"),-15}\n{"",-5}Ngay Kham:{this._ngayKham.ToString("dd/MM/yyyy"),10}\n{"",-5}Ma so Bao Hiem:{this._maSoBaoHiem,10}\n{"",-5}Ma Toa Thuoc:{this._maToaThuoc,10}\nBenh nhan thu: {SoLuongBenhNhan}");
        }
    }
}
