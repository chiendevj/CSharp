using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThuVien
{
    class Color
    {
     
        //Màu đỏ cho những thông báo không thành công, thoát chương trình
        public static ConsoleColor errorColor = ConsoleColor.Red;
        //Màu xanh cho những thông báo thực hiện thành công
        public static ConsoleColor successColor = ConsoleColor.DarkGreen;
        //Màu DarkCyan cho nội dung trong header cua bảng
        public static ConsoleColor tableColor = ConsoleColor.DarkCyan;
        //Màu Gray cho khung bảng
        public static ConsoleColor aroundTableColor = ConsoleColor.Gray;
        //Màu White cho nội dung hiển thị trong bảng
        public static ConsoleColor textTableColor = ConsoleColor.White;
        //Màu Blue cho những nội dung trong menu chức năng
        public static ConsoleColor titleTableColor = ConsoleColor.Blue;
        //Màu yellow cho những thông báo
        public static ConsoleColor notiColor = ConsoleColor.Yellow;
        //Màu trắng cho những nội dung
        public static ConsoleColor textColor = ConsoleColor.White;
    }
}