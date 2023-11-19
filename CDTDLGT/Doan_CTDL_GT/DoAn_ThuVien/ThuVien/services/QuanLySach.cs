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
    class QuanLySach
    {
        // Fields
        private LinkedList<Sach> danhSachSach; // Danh sách liên kết chứa các đối tượng sách
        private string tenFile = "data/Sach.txt"; // Đường dẫn file để lưu thông tin sách
        Utility util = new Utility();

        public string TenFile
        {
            get
            {
                return tenFile;
            }
        }

        // Properties
        public LinkedList<Sach> QlSach
        {
            get
            {
                return danhSachSach;
            }
            set
            {
                danhSachSach = value;
            }
        }

        // Contructors  
        public QuanLySach()
        {
            this.danhSachSach = DocDanhSachSach(tenFile); // Khởi tạo đối tượng QuanLySach và đọc danh sách sách từ file
        }

        public QuanLySach(LinkedList<Sach> qlSach)
        {
            this.danhSachSach = qlSach; // Khởi tạo đối tượng QuanLySach với danh sách sách đã cho
        }

        // Methods
        // Đọc danh sách sách từ file
        public LinkedList<Sach> DocDanhSachSach(string path)
        {
            LinkedList<Sach> dsSach = new LinkedList<Sach>();
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string s = null;
                    while ((s = reader.ReadLine()) != null)
                    {
                        string[] arrS = s.Split('#');
                        string maSach = arrS[0];
                        string tenSach = arrS[1];
                        string tacGia = arrS[2];
                        string nhaXB = arrS[3];
                        double giaBan = double.Parse(arrS[4]);
                        int namPhatHanh = int.Parse(arrS[5]);
                        int soTrang = int.Parse(arrS[6]);
                        DateTime ngayNhapKho = DateTime.ParseExact(arrS[7], "dd/MM/yyyy", null);
                        int tinhTrang = int.Parse(arrS[8]);
                        Sach sach = new Sach(maSach, tenSach, tacGia, nhaXB, giaBan, namPhatHanh, soTrang, ngayNhapKho, tinhTrang);
                        dsSach.AddLast(sach);
                    }
                }
            }
            catch (Exception)
            {
                // System.Console.WriteLine(e);
                throw new Exception("Doc file khong thanh cong!");
            }

            return dsSach;
        }

        // In danh sách sách ra màn hình
        public void HienThiDanhSachSach()
        {

            Console.ForegroundColor = Color.notiColor;
            util.CenterContent("DANH SACH CAC QUYEN SACH HIEN CO", true);
            Console.WriteLine();

            this.danhSachSach = DocDanhSachSach(tenFile);
            List<String> title = new List<string> { "Ma sach", "Ten sach", "Tac gia", "Nha XB", "Gia ban", "Nam", "So trang", "Ngay nhap kho", "Tinh trang" }; // khởi tạo các tiêu để cho bảng
            List<int> colLength = new List<int> { 10, 25, 20, 20, 10, 10, 10, 14, 12 }; // khởi tạo độ rộng cho các cột của bảng
            List<String> value = new List<string>();


            foreach (Sach item in danhSachSach)
            {
                // thêm các giá trị vảo vào bảng
                value.Add(item.MaSach); 
                value.Add(item.TenSach);
                value.Add(item.TacGia);
                value.Add(item.NhaXB);
                value.Add(item.GiaBan.ToString());
                value.Add(item.NamPhatHanh.ToString());
                value.Add(item.SoTrang.ToString());
                value.Add(item.NgayNhapKho.ToString("dd/MM/yyyy"));
                value.Add(item.TinhTrang.ToString());
            }

            DrawTable table = new DrawTable(title.Count, colLength, title, value); // vẽ bảng
        }

        // Ghi thông tin sách vào file
        public void GhiThemSachFile(string path, Sach sach)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, true);
                using (writer)
                {
                    writer.WriteLine(sach.printFile());
                }
            }
            catch (Exception)
            {
                throw new Exception("Ghi them sach khong thanh cong!");
            }
        }

        // Ghi lại danh sách sách sau khi xóa sách
        public void GhiLaiDSSachFile(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Sach item in danhSachSach)
                    {
                        writer.WriteLine(item.printFile());
                    }
                    // Console.WriteLine("Ghi danh sach sach thanh cong!");
                }
            }
            catch (Exception)
            {

                throw new Exception("Ghi danh sach sach khong thanh cong!");
            }
        }
        // Xóa sách khỏi danh sách sách
        public void XoaSach()
        {
            this.danhSachSach = DocDanhSachSach(tenFile);
            Console.ForegroundColor = Color.notiColor;
            int firstLine = util.CenterContent("THUC HIEN XOA SACH", true);
            System.Console.WriteLine();
            Console.ForegroundColor = Color.textColor;
            util.SetXCursor(firstLine);
            Console.Write("Nhap ma sach can xoa: ");
            string maSach = Console.ReadLine();
            Sach sach = TimSach(maSach); // Tìm sách theo mã sách
            if (sach != null && sach.TinhTrang == 0) // Kiểm tra sách tồn tại và không được mượn
            {
                danhSachSach.Remove(sach); // Xóa sách khỏi danh sách
                GhiLaiDSSachFile(tenFile); // Ghi lại danh sách sách vào file
                Console.ForegroundColor = Color.successColor;
                util.SetXCursor(firstLine);
                Console.WriteLine("Da xoa sach thanh cong!"); // In thông báo thành công
            }
            else
            {
                if (sach == null)
                {
                    Console.ForegroundColor = Color.errorColor;
                    util.SetXCursor(firstLine);
                    Console.WriteLine("Chua xoa duoc sach. Do sach khong ton tai!"); // In thông báo không thành công vì sách không tồn tại
                }
                else
                {
                    Console.ForegroundColor = Color.errorColor;
                    util.SetXCursor(firstLine);
                    Console.WriteLine("Chua xoa duoc sach. Do sach da duoc muon!"); // In thông báo không thành công vì sách đã được mượn
                }
            }
        }
        // Tìm sách theo mã sách
        public Sach TimSach(string maSach)
        {
            for (LinkedListNode<Sach> p = danhSachSach.First; p != null; p = p.Next)
            {
                if (p.Value.MaSach.Equals(maSach)) // So sánh mã sách
                {
                    return p.Value;
                }
            }
            return null; // Trả về sách tìm được (hoặc null nếu không tìm thấy)
        }
        // Thêm sách vào danh sách sách
        public bool ThemSach()
        {
            Console.ForegroundColor = Color.notiColor;
            int firstLine = util.CenterContent("THUC HIEN THEM SACH", true);
            double giaBan = 0;
            int namPhatHanh = 0;
            int soTrang = 0;
            int tinhTrang = 0;
            DateTime ngayNhapKho = new DateTime();
            Console.ForegroundColor = Color.textColor;
            util.SetXCursor(firstLine);
            Console.Write("Nhap ma sach: ");
            string maSach = Console.ReadLine();

            //Kiểm tra xem nếu mã sách rỗng cho người dùng nhập lại
            while (maSach == "" || TimSach(maSach) != null || maSach[0] != 'B')
            {
                if (TimSach(maSach) != null)
                {
                    Console.ForegroundColor = Color.errorColor;
                    util.SetXCursor(firstLine);
                    Console.WriteLine("Khong the them sach. Do sanh da bi trung!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    maSach = Console.ReadLine();
                }

                if (maSach == "")
                {
                    Console.ForegroundColor = Color.errorColor;
                    util.SetXCursor(firstLine);
                    Console.WriteLine("Nhap ma sach khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    maSach = Console.ReadLine();
                }
                else
                {
                    if (maSach[0] != 'B')
                    {
                        Console.ForegroundColor = Color.errorColor;
                        util.SetXCursor(firstLine);
                        Console.WriteLine("Nhap ma sach khong hop le!");
                        util.SetXCursor(firstLine);
                        Console.ForegroundColor = Color.textColor;
                        Console.Write("Nhap lai: ");
                        maSach = Console.ReadLine();
                    }
                    //Kiểm tra nếu mã sách có kí tự đầu khác B và kí tự sau khác số thì phải nhập lại
                    for (int i = 1; i < maSach.Length; i++)
                    {
                        while (maSach[i] < '0' || maSach[i] > '9')
                        {
                            util.SetXCursor(firstLine);
                            Console.ForegroundColor = Color.errorColor;
                            Console.WriteLine("Nhap ma sach khong hop le!");
                            util.SetXCursor(firstLine);
                            Console.ForegroundColor = Color.textColor;
                            Console.Write("Nhap lai: ");
                            maSach = Console.ReadLine();
                        }
                    }
                }

               
            }

            // Kiểm tra mã sách
            if (!maSach.Equals("") && TimSach(maSach) == null) // So sánh mã sách
            {
                util.SetXCursor(firstLine);
                Console.Write("Nhap ten sach: ");
                string tenSach = Console.ReadLine();
                //Kiểm tra tên sách nhập vào nếu là rỗng hoặc khoảng trắng phải thì nhập lại
                while (tenSach == "" || tenSach == " ")
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Ten sach khong the trong!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    tenSach = Console.ReadLine();
                }
                util.SetXCursor(firstLine);
                Console.Write("Nhap tac gia sach: ");
                string tacGia = Console.ReadLine();
                //Kiểm tra tác giả nhập vào nếu là rỗng hoặc khoảng trắng phải thì nhập lại
                while (tacGia == "" || tacGia == " ")
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap ten sach khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    tacGia = Console.ReadLine();
                }

                util.SetXCursor(firstLine);
                Console.Write("Nhap nha xuat ban sach: ");
                string nhaXB = Console.ReadLine();
                //Kiểm tra nhà xuất bản nhập vào nếu là rỗng hoặc khoảng trắng phải thì nhập lại
                while (nhaXB == "" || nhaXB == " ")
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap nha xuat ban khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    nhaXB = Console.ReadLine();
                }
                util.SetXCursor(firstLine);
                Console.Write("Nhap gia ban cua sach: ");
                double.TryParse(Console.ReadLine(), out giaBan);
                //Kiểm tra giá bán nhỏ hơn 0 hoặc không hợp lệ thì phải nhập lại
                while (giaBan <= 0)
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap gia ban khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    double.TryParse(Console.ReadLine(), out giaBan);
                }
                util.SetXCursor(firstLine);
                Console.Write("Nhap nam phat cua sach: ");
                int.TryParse(Console.ReadLine(), out namPhatHanh);
                //Kiểm tra năm phát hành nếu nhỏ hơn 0 hoặc không hợp lệ thì phải nhập lại
                while (namPhatHanh <= 0)
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap nam phat hanh khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    int.TryParse(Console.ReadLine(), out namPhatHanh);
                }
                util.SetXCursor(firstLine);
                Console.Write("Nhap so trang: ");
                int.TryParse(Console.ReadLine(), out soTrang);
                //Kiểm tra số trang nếu nhỏ hơn 0 hoặc không hợp lệ thì phải nhập lại
                while (soTrang <= 0)
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap so trang khong hop le!");
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.textColor;
                    Console.Write("Nhap lai: ");
                    int.TryParse(Console.ReadLine(), out soTrang);
                }

                util.SetXCursor(firstLine);
                Console.Write("Nhap ngay nhap kho: ");
                DateTime.TryParse(Console.ReadLine(), out ngayNhapKho);
                //Kiểm tra ngày nhập kho nếu không hợp lệ thì phải nhập lại
                while (ngayNhapKho == new DateTime(1, 1, 1))
                {
                    util.SetXCursor(firstLine);
                    Console.ForegroundColor = Color.errorColor;
                    Console.WriteLine("Nhap ngay nhap kho khong hop le!");
                    Console.ForegroundColor = Color.textColor;
                    util.SetXCursor(firstLine);
                    Console.Write("Nhap lai: ");
                    DateTime.TryParse(Console.ReadLine(), out ngayNhapKho);
                } 
                Sach sach = new Sach(maSach, tenSach, tacGia, nhaXB, giaBan, namPhatHanh, soTrang, ngayNhapKho, tinhTrang);
                GhiThemSachFile(tenFile, sach); //Ghi thêm sách mới thêm nào file
                Console.ForegroundColor = Color.successColor;
                util.SetXCursor(firstLine);
                Console.WriteLine("Them sach thanh cong!");
                return true;
            }
            return false;

        }

        

    }
}