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
    class QuanLyBanDoc
    {
        // Fields
        private LinkedList<BanDoc> danhSachBanDoc; // Danh sách liên kết chứa các đối tượng bạn đọc
        private string tenFile = "data/BanDoc.txt"; // Đường dẫn file để lưu thông tin bạn đọc

        // Propreties
        public LinkedList<BanDoc> QlBanDoc
        {
            get
            {
                return danhSachBanDoc;
            }
            set
            {
                danhSachBanDoc = value;
            }
        }

        // Contructors  
        public QuanLyBanDoc()
        {
            this.danhSachBanDoc = DocDanhSachBanDoc(tenFile); // Khởi tạo đối tượng QuanLyBanDoc và đọc danh sách sách từ file
        }
        public QuanLyBanDoc(LinkedList<BanDoc> danhSachBanDoc)
        {
            this.danhSachBanDoc = danhSachBanDoc; // Khởi tạo đối tượng QuanLyBanDoc với danh sách sách đã cho
        }

        // Methods
        // Đọc danh sách bạn đọc từ file
        public LinkedList<BanDoc> DocDanhSachBanDoc(string path)
        {
            LinkedList<BanDoc> dsBanDoc = new LinkedList<BanDoc>();
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string s = null;
                    while ((s = reader.ReadLine()) != null)
                    {
                        string[] arrS = s.Split('#');
                        string maBanDoc = arrS[0];
                        string hoTen = arrS[1];
                        DateTime ngayDangKy = DateTime.ParseExact(arrS[2], "dd/MM/yyyy", null);
                        BanDoc banDoc = new BanDoc(maBanDoc, hoTen, ngayDangKy);
                        dsBanDoc.AddLast(banDoc);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Doc file khong thanh cong!");
            }

            return dsBanDoc;
        }

        // Tìm bạn đọc theo mã bạn đọc
        public BanDoc TimBanDocTheoMaBanDoc(string maBanDoc)
        {
            BanDoc banDoc = null;

            foreach (BanDoc item in danhSachBanDoc)
            {
                if (item.MaBanDoc.Equals(maBanDoc))
                {
                    banDoc = item;
                }
            }

            return banDoc;
        }

        // Hiển thị danh sách bạn đọc
        public void HienThiDanhSachBanDoc()
        {
            List<String> title = new List<string> { "Ma ban doc", "Ten ban doc", "Ngay dang ky" }; // khởi tạo các tiêu để cho bảng
            List<int> colLength = new List<int> { 14, 26, 14 }; // khởi tạo độ rộng cho các cột của bảng
            List<String> value = new List<string>();


            foreach (BanDoc item in danhSachBanDoc)
            {
                value.Add(item.MaBanDoc); // thêm các giá trị cần in vảo vào bảng
                value.Add(item.HoTen);
                value.Add(item.NgayDangKy.ToString("dd/MM/yyyy"));
            }

            DrawTable table = new DrawTable(title.Count, colLength, title, value); // vẽ bảng
        }
    }
}