using System;
using System.IO;
// Đọc file HangHoa.txt và xuất ra thông tin như bảng.
namespace BT4_File
{
    class HangHoa
    {
        private string maHang;
        private string tenHang;
        private int soLuong;
        private int giaHang;
    }
    internal class BT4_File
    {
        static void Main(string[] args)
        {
            HangHoa hh = new HangHoa();
            string path = "";
            string text = null;
            
            path = "H:\\IT_Language\\C#\\CDTDLGT\\FileCSharp\\BT3_File\\HangHoa.txt";
            StreamReader sd = new StreamReader(path);
            text = sd.ReadToEnd();
            string[] str = new string[text.Length];
            str = text.Split('#');
            Console.WriteLine(str);
            sd.Close();
        }

    }
}
