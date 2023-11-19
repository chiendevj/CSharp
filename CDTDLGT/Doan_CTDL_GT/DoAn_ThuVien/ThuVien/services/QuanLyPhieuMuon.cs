using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThuVien
{
    class QuanLyPhieuMuon
    {

        // Fields
        private LinkedList<PhieuMuon> danhSachPhieuMuon; // Danh sách liên kết chứa các đối tượng phiếu mượn
        private string tenFile = "data/PhieuMuon.txt"; // Đường dẫn file để lưu thông tin phiếu mượn
        Utility util = new Utility();

        // Properties
        public LinkedList<PhieuMuon> QlSach
        {
            get
            {
                return danhSachPhieuMuon;
            }
            set
            {
                danhSachPhieuMuon = value;
            }
        }

        // Contructors  
        public QuanLyPhieuMuon()
        {
            this.danhSachPhieuMuon = DocDanhSachPhieuMuon(tenFile); // Khởi tạo đối tượng danhSachPhieuMuon và đọc danh sách phiếu mượn từ file
        }
        public QuanLyPhieuMuon(LinkedList<PhieuMuon> danhSachPhieuMuon)
        {
            this.danhSachPhieuMuon = danhSachPhieuMuon; // Khởi tạo đối tượng danhSachPhieuMuon với danh sách phiếu mượn đã cho
        }

        // Methods
        // Đọc danh sách phiếu mượn từ file
        public LinkedList<PhieuMuon> DocDanhSachPhieuMuon(string path)
        {
            LinkedList<PhieuMuon> dsPhieuMuon = new LinkedList<PhieuMuon>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string s = null;
                    while ((s = reader.ReadLine()) != null)
                    {
                        string[] arrS = s.Split('#');
                        int soPhieuMuon = int.Parse(arrS[0]);
                        string maDocGia = arrS[1];
                        string maSach = arrS[2];
                        int tinhTrang = int.Parse(arrS[3]);
                        DateTime ngayMuon = DateTime.ParseExact(arrS[4], "dd/MM/yyyy", null);
                        DateTime ngayTra = DateTime.ParseExact(arrS[5], "dd/MM/yyyy", null);

                        QuanLyBanDoc qlBanDoc = new QuanLyBanDoc();
                        QuanLySach qlSach = new QuanLySach();

                        Sach sach = qlSach.TimSach(maSach);
                        BanDoc banDoc = qlBanDoc.TimBanDocTheoMaBanDoc(maDocGia);

                        PhieuMuon phieuMuon = new PhieuMuon(soPhieuMuon, banDoc, sach, tinhTrang, ngayMuon, ngayTra);
                        dsPhieuMuon.AddLast(phieuMuon);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Doc file khong thanh cong!");
            }
            return dsPhieuMuon;
        }

        // Hiển thỉ bảng danh sách phiếu mượn
        public void HienThiDanhSachPhieuMuon()
        {
            this.danhSachPhieuMuon = DocDanhSachPhieuMuon(tenFile);
            Console.ForegroundColor = Color.notiColor;
            util.CenterContent("DANH SACH PHIEU MUON", true);
            Console.WriteLine();
            List<String> title = new List<string> { "So Phieu", "Ma ban doc", "Ten ban doc", "Ma sach", "Ten sach", "Trang thai", "Ngay muon", "Han Tra" }; // khởi tạo các tiêu để cho bảng
            List<int> colLength = new List<int> { 10, 14, 26, 14, 30, 12, 14, 14 }; // khởi tạo độ rộng cho các cột của bảng
            List<String> value = new List<string>();


            foreach (PhieuMuon item in danhSachPhieuMuon)
            {
                value.Add(item.SoPhieuMuon.ToString()); // thêm các giá trị cần in vảo vào bảng
                value.Add(item.ThongTinBanDoc.MaBanDoc);
                value.Add(item.ThongTinBanDoc.HoTen);
                value.Add(item.ThongTinSach.MaSach);
                value.Add(item.ThongTinSach.TenSach);
                value.Add(item.TinhTrang.ToString());
                value.Add(item.NgayMuonSach.ToString("dd/MM/yyyy"));
                value.Add(item.NgayTraSach.ToString("dd/MM/yyyy"));
            }

            DrawTable table = new DrawTable(title.Count, colLength, title, value); // vẽ bảng
        }


        // Hàm thực hiện việc mượn sách
        public void MuonSach()
        {
            this.danhSachPhieuMuon = DocDanhSachPhieuMuon(tenFile);
            Console.ForegroundColor = Color.notiColor;
            int firstLine = util.CenterContent("THUC HIEN MUON SACH", true);
            System.Console.WriteLine();
            Console.ForegroundColor = Color.textColor;
            util.SetXCursor(firstLine);
            Console.Write("Nhap vao ma ban doc: ");
            string maBanDoc = Console.ReadLine();
            QuanLyBanDoc qlBanDoc = new QuanLyBanDoc();
            QuanLySach qlSach = new QuanLySach();
            BanDoc banDoc = qlBanDoc.TimBanDocTheoMaBanDoc(maBanDoc); // kiểm tra thông tin bạn đọc có tồn tại hay không
            if (banDoc != null)
            {
                util.SetXCursor(firstLine);
                Console.Write("Nhap vao ma sach: ");
                string maSach = Console.ReadLine();


                Sach sach = qlSach.TimSach(maSach); // kiểm tra mã sách có tồn tại hay không

                if (sach != null)
                {
                    if (sach.TinhTrang == 0) // nếu tình trạng sách có thể mượn 
                    {
                        int soPhieuMuon = danhSachPhieuMuon.Last.Value.SoPhieuMuon + 1; // tạo phiếu mượn mới
                        PhieuMuon phieuMuon = new PhieuMuon(soPhieuMuon, banDoc, sach, 1, DateTime.Now);
                        GhiThemPhieuMuonFile(tenFile, phieuMuon);
                        sach.TinhTrang = soPhieuMuon;
                        qlSach.GhiLaiDSSachFile(qlSach.TenFile);
                        util.SetXCursor(firstLine);
                        Console.ForegroundColor = Color.successColor;
                        Console.WriteLine("Muon thanh cong !");
                    }
                    else
                    {
                        util.SetXCursor(firstLine);
                        Console.ForegroundColor = Color.errorColor;
                        Console.WriteLine("Sach da duoc muon!"); // xuất thông báo nếu sách đã được mượn
                    }
                }
                else
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Khong tim thay sach!"); // xuất thông báo nếu không tìm thấy sách
                }
            }
            else
            {
                util.SetXCursor(firstLine);
                Console.ForegroundColor = Color.errorColor;
                Console.WriteLine("Khong tim thay ban doc nay!"); // xuất thông báo nếu không tìm thấy bạn đọc
            }
        }

        // Hàm thực hiện trả sách
        public void TraSach()
        {
            this.danhSachPhieuMuon = DocDanhSachPhieuMuon(tenFile);
            Console.ForegroundColor = Color.notiColor;
            int firstLine = util.CenterContent("THUC HIEN TRA SACH", true);
            System.Console.WriteLine();
            util.SetXCursor(firstLine);
            Console.ForegroundColor = Color.textColor;
            Console.Write("Nhap vao so phieu muon: ");
            int soPhieuMuon = 0;
            int.TryParse(Console.ReadLine(), out soPhieuMuon);
            PhieuMuon phieuMuon = TimPhieuMuonTheoMaPhieuMuon(soPhieuMuon);
            if (phieuMuon != null)
            {
                if (phieuMuon.TinhTrang != 0)
                {
                    QuanLySach qlSach = new QuanLySach();
                    Sach sach = qlSach.TimSach(phieuMuon.ThongTinSach.MaSach);
                    sach.TinhTrang = 0;
                    phieuMuon.TinhTrang = 0;
                    qlSach.GhiLaiDSSachFile(qlSach.TenFile);
                    GhiDSPhieMuonFile(tenFile);
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.successColor;
                    Console.WriteLine("Cap nhat thanh cong!");
                }
                else
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Phieu muon da duoc tra!");
                }
            }
            else
            {
                util.SetXCursor(firstLine);
                Console.ForegroundColor = Color.errorColor;
                Console.WriteLine("Khong ton tai phieu muon!");
            }
        }

        // Hàm tìm phiếu mượn theo mã phiếu mượn
        public PhieuMuon TimPhieuMuonTheoMaPhieuMuon(int soPhieuMuon)
        {
            PhieuMuon phieuMuon = null;
            foreach (PhieuMuon item in danhSachPhieuMuon)
            {
                if (item.SoPhieuMuon.Equals(soPhieuMuon)) // So sánh số phiếu mượn
                {
                    phieuMuon = item; // Gán phiếu mượn tìm được vào biến phieuMuon
                }
            }
            return phieuMuon; // Trả về phiếu mượn tìm được (hoặc null nếu không tìm thấy)
        }

        // Xuất các phiếu mượn qúa hạn
        public void XuatPhieuMuonQuaHan()
        {
            this.danhSachPhieuMuon = DocDanhSachPhieuMuon(tenFile);
            Console.ForegroundColor = Color.notiColor;
            util.CenterContent("DANH SACH PHIEU MUON TRE HAN", true);
            System.Console.WriteLine();
            List<string> dsPhieuMuonQuaHan = new List<string>();
            List<string> title = new List<string> { "So phieu", "Ngay muon", "Ngay tra", "So ngay qua han" }; // khởi tạo các tiêu để cho bảng
            List<int> col = new List<int> { 14, 14, 14, 16 }; // khởi tạo độ dài các cột cho bảng
            foreach (PhieuMuon item in danhSachPhieuMuon)
            {
                double soNgayQuaHan = item.SoNgayQuaHanTra();
                if (soNgayQuaHan > 0 && item.TinhTrang != 0)
                {
                    dsPhieuMuonQuaHan.Add(item.SoPhieuMuon.ToString()); // thêm dữ liệu cho bảng
                    dsPhieuMuonQuaHan.Add(item.NgayMuonSach.ToString("dd/MM/yyyy"));
                    dsPhieuMuonQuaHan.Add(item.NgayTraSach.ToString("dd/MM/yyyy"));
                    dsPhieuMuonQuaHan.Add(soNgayQuaHan.ToString());
                }
            }

            DrawTable table = new DrawTable(title.Count(), col, title, dsPhieuMuonQuaHan);
        }

        // Ghi thông tin sách vào file
        public void GhiThemPhieuMuonFile(string path, PhieuMuon phieuMuon)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(phieuMuon.printFile());
                }
            }
            catch (Exception)
            {
                throw new Exception("Ghi them phieu muon khong thanh cong!");
            }
        }

        // Ghi lại danh sách sách
        public void GhiDSPhieMuonFile(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (PhieuMuon item in danhSachPhieuMuon)
                    {
                        writer.WriteLine(item.printFile());
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ghi danh sach phieu muon khong thanh cong!");
            }
        }
    }
}