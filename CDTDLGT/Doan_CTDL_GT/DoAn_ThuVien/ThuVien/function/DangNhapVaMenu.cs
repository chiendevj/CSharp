using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ThuVien
{
    class DangNhapVaMenu
    {
        private string textNotification1 = "Ban co 3 luot dang nhap";
        private string textNotification2 = "";
        private string textUser = "";
        private string textPassword = "";
        int soLanDangNhap = 2; // Biến đếm số lần đăng nhập

        //Hàm hiển thị chức năng đăng nhập
        public void Login()
        {
            Utility utility = new Utility();
            string boxTitle = "**************************************";
            string title = "          D A N G  N H A P        ";
            string user = "User     : ";
            string password = "Password : ";

            Console.ForegroundColor = Color.tableColor;
            int firstLine = utility.CenterContent(boxTitle, true);
            Console.WriteLine();
            utility.SetXCursor(firstLine);
            Console.Write("*");
            Console.ForegroundColor = Color.textColor;
            new CenterText(title);
            Console.ForegroundColor = Color.tableColor;
            Console.WriteLine("*");
            Console.WriteLine();
            Console.ForegroundColor = Color.tableColor;
            new CenterText(boxTitle);
            Console.WriteLine("\n\n");
            Console.ForegroundColor = Color.notiColor;
            new CenterText(textNotification1);
            Console.ForegroundColor = Color.errorColor;
            new CenterText(textNotification2);
            Console.WriteLine();
            Console.ForegroundColor = Color.textColor;
            new CenterText(user);
            textUser = Console.ReadLine();
            Console.WriteLine();

            // Hiển thị mật khẩu của người dùng dưới dạng ****** khi nhập trên màn hình Console;
            new CenterText(password);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (textPassword.Length > 0)
                    {
                        textPassword = textPassword.Substring(0, textPassword.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    textPassword += key.KeyChar;
                    Console.Write("*");
                }
            }

            // Check account
            if (KiemTraDangNhap())
            {
                Console.Clear();
                Menu();
            }
        }

        //Hàm kiểm tra đăng nhập xem có hợp lệ hay không
        public bool KiemTraDangNhap()
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.readerFile();

            while (soLanDangNhap >= 0)
            {
                if (quanLyTaiKhoan.checkLogin(textUser, textPassword) == true)
                {
                    soLanDangNhap = 0;
                    return true;
                }
                else
                {
                    if (soLanDangNhap == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = Color.errorColor;
                        new CenterText("Ban da nhap sai qua 3 lan. Vui long thu lai!");
                        return false;
                    }
                    textPassword = ""; // Đưa mật khẩu về rỗng
                    textNotification1 = $"Ban con {soLanDangNhap} lan dang nhap";
                    textNotification2 = "Dang nhap that bai, Vui kiem tra username or password!!";
                    Console.Clear();
                    soLanDangNhap--; // Giảm số lần đăng nhập đi 1, nếu < 0 thì sẽ out.
                    Login();
                }
            }
            return false;
        }

        //Hàm in ra tiêu đề của menu chính 
        public void Menu()
        {
            string boxTitle =    "**************************************";
            string titleMenu =   "*               M E N U              *";
            string selectMenu1 = "*          1. Quan ly sach           *";
            string selectMenu2 = "*          2. Quan ly phieu muon     *";
            string selectMenu3 = "Nhap ky tu khac de dang xuat. ESC de thoat!!!";
            string textSelect = "--> Nhap lua chon : ";
            ConsoleKeyInfo phimChon;
            Console.ForegroundColor = Color.tableColor;
            new CenterText(boxTitle);
            Console.WriteLine();
            new CenterText(titleMenu);
            Console.WriteLine();
            new CenterText(selectMenu1);
            Console.WriteLine();
            new CenterText(selectMenu2);
            Console.WriteLine();
            new CenterText(boxTitle);
            Console.ForegroundColor = Color.notiColor;
            new CenterText(selectMenu3);
            Console.WriteLine();
            Console.ForegroundColor = Color.textColor;
            new CenterText(textSelect);
            phimChon = Console.ReadKey(true);
            NavMenu(phimChon);
        }

        //Hàm in ra menu chính với hai chưc năng  quản lý sách và mượn sách
        public void NavMenu(ConsoleKeyInfo select)
        {
            switch (select.KeyChar)
            {
                case '1':
                        MenuQuanLySach();
                    break;
                case '2':
                         MenuQuanLyMuonTraSach();
                    break;
                default:
                    if (select.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        GiaoDienDung();
                        return;
                    }
                    Console.Clear();
                    soLanDangNhap = 2;
                    textNotification1 = "Ban co 3 luot dang nhap";
                    textNotification2 = "";
                    Login();
                    return;
            }

        }


        //Ham in ra menu quản lý sách
        public void MenuQuanLySach()
        {
            QuanLySach quanLySach = new QuanLySach();
            Utility utils = new Utility();
            ConsoleKeyInfo luaChon;
            do
            {
                Console.Clear();
                InKhungQuanLySach();
                Console.ForegroundColor = Color.tableColor;
                int firstLine = utils.CenterContent("________________________________________", true);
                utils.SetXCursor(firstLine);
                Console.WriteLine("|                                      |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      1. Hien thi thong tin sach      |", true);
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      2. Them sach                    |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      3. Xoa sach                     |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|______________________________________|");
        
                Console.ForegroundColor = Color.notiColor;
                utils.CenterContent("Bam phim bat ky de quay tro lai. Bam ESC de thoat!", true);
                System.Console.WriteLine();

                utils.SetXCursor(firstLine);
                Console.ForegroundColor = Color.textColor;
                Console.Write("Nhap vao lua chon cua ban: ");
                luaChon = Console.ReadKey();
                switch (luaChon.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        InKhungQuanLySach();
                        quanLySach.HienThiDanhSachSach();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        InKhungQuanLySach();
                        quanLySach.ThemSach();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        InKhungQuanLySach();
                        quanLySach.XoaSach();
                        Console.ReadKey();
                        break;
                    default:
                        //Kiểm tra nếu nhấn ESC thì thoát chương trình và hiện ra khung thông báo đã thoát
                        if (luaChon.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                           
                            utils.SetXCursor(firstLine);
                            Console.WriteLine();
                            utils.SetXCursor(firstLine);
                            Console.WriteLine();
                            utils.SetXCursor(firstLine);
                            Console.WriteLine("                             ");
                            GiaoDienDung();
                            return;
                        }

                        //Bấm phím bất kì khác 1 đến 4 để quay về menu chức năng
                        Console.Clear();
                        Console.ForegroundColor = Color.notiColor;
                        Console.WriteLine();
                        InKhungThoatQuanLySach();
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break ;
                }
            } while (luaChon.KeyChar >= '1' && luaChon.KeyChar <= '3');
        }
    
        // Hàm in ra menu quản lý phiếu mượn
        public void MenuQuanLyMuonTraSach()
        {
            QuanLyBanDoc quanLyBanDoc = new QuanLyBanDoc();
            QuanLyPhieuMuon quanLyPhieuMuon = new QuanLyPhieuMuon();
            Utility utils = new Utility();
            ConsoleKeyInfo luaChon;
            do
            {
                Console.Clear();
                InKhungQuanLyPhieuMuon();
                Console.ForegroundColor = Color.tableColor;
                int firstLine = utils.CenterContent("__________________________________________", true);
                utils.SetXCursor(firstLine);
                Console.WriteLine("|                                        |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      1. Hien thi thong tin phieu muon  |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      2. Muon sach                      |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      3. Tra sach                       |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|      4. Hien thi phieu muon qua han    |");
                utils.SetXCursor(firstLine);
                Console.WriteLine("|________________________________________|");
                Console.ForegroundColor = Color.notiColor;
                utils.CenterContent("Bam phim bat ky de quay tro lai. Bam ESC de thoat!", true);
                System.Console.WriteLine();

                utils.SetXCursor(firstLine);
                Console.ForegroundColor = Color.textColor;
                Console.Write("Nhap vao lua chon cua ban: ");
                luaChon = Console.ReadKey();

                switch (luaChon.KeyChar)
                {

                    case '1':
                        Console.Clear();
                        InKhungQuanLyPhieuMuon();
                        quanLyPhieuMuon.HienThiDanhSachPhieuMuon();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        InKhungQuanLyPhieuMuon();
                        quanLyPhieuMuon.MuonSach();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        InKhungQuanLyPhieuMuon();
                        quanLyPhieuMuon.TraSach();
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.Clear();
                        InKhungQuanLyPhieuMuon();
                        quanLyPhieuMuon.XuatPhieuMuonQuaHan();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        if (luaChon.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();

                            utils.SetXCursor(firstLine);
                            Console.WriteLine();
                            utils.SetXCursor(firstLine);
                            Console.WriteLine();
                            utils.SetXCursor(firstLine);
                            Console.WriteLine("                             ");
                            GiaoDienDung();
                            return;
                        }
                        Console.ForegroundColor = Color.notiColor;
                        Console.WriteLine();
                        InKhungThoatQuanLyPhieuMuon();
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                }
            } while (luaChon.KeyChar >= '1' && luaChon.KeyChar <= '4');
        }

        // Hàm in giao diện khi bấm ESC để thông báo thoát khỏi chương trình quản lý
        public void GiaoDienDung()
        {
            Console.ForegroundColor = Color.errorColor;
            Utility utils = new Utility();
            int firstLine = utils.CenterContent("________________________________________", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|                                      |");
            utils.SetXCursor(firstLine);
            Console.WriteLine("|   BAN DA CHON THOAT CHUONG TRINH!!!  |", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|______________________________________|");
            Console.WriteLine();
        }

        //Ham in ra khung quản lý sách trong các chức năng con
        public void InKhungQuanLySach()
        {
            Console.ForegroundColor = Color.tableColor;
            Utility utils = new Utility();
            int firstLine = utils.CenterContent("________________________________________", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|                                      |");
            utils.SetXCursor(firstLine);
            Console.WriteLine("|             QUAN LY SACH             |", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|______________________________________|");
            Console.WriteLine();
        }

        //Ham in khung quản ý phiếu mượn trong các chức năng con
        public void InKhungQuanLyPhieuMuon()
        {
            Console.ForegroundColor = Color.tableColor;
            Utility utils = new Utility();
            int firstLine = utils.CenterContent("________________________________________", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|                                      |");
            utils.SetXCursor(firstLine);
            Console.WriteLine("|           QUAN LY PHIEU MUON         |", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|______________________________________|");
            Console.WriteLine();
        }

        //Hàm in khung  thoát chức năng quản lý phiếu mượn
        public void InKhungThoatQuanLyPhieuMuon()
        {
            Utility utils = new Utility();
            int firstLine = utils.CenterContent("__________________________________________________________", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|                                                        |");
            utils.SetXCursor(firstLine);
            Console.WriteLine("|           BAN DA CHON THOAT QUAN LY PHIEU MUON         |", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|________________________________________________________|");
            Console.WriteLine();
        }

        //Hàm in khung thoát chức năng quản lý sách
        public void InKhungThoatQuanLySach()
        {
            Utility utils = new Utility();
            int firstLine = utils.CenterContent("____________________________________________________", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|                                                  |");
            utils.SetXCursor(firstLine);
            Console.WriteLine("|           BAN DA CHON THOAT QUAN LY SACH         |", true);
            utils.SetXCursor(firstLine);
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine();
        }
    }
}
