using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class QuanLyTaiKhoan
    {
        private LinkedList<Admin> danhSachTaiKhoan = new LinkedList<Admin>();

        public LinkedList<Admin> readerFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("data/Admin.txt"))
                {
                    string lines = null;
                    while ((lines = sr.ReadLine()) != null)
                    {
                        string[] info = lines.Split('#');
                        Admin admin = new Admin(info[0], info[1]);
                        this.danhSachTaiKhoan.AddLast(admin);
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
            return this.danhSachTaiKhoan;
        }

        // Kiểm tra thông tin đăng nhập
        public bool checkLogin(string username, string password)
        {

            for (LinkedListNode<Admin> p = danhSachTaiKhoan.First; p != null; p = p.Next)
            {
                if ((p.Value.User() == username) && (p.Value.PassWord() == password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}