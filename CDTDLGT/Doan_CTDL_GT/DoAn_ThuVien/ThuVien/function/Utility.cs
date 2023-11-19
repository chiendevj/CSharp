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
    class Utility
    {
        /// <summary>
        /// Căn giữa nội dung và hiển thị trên màn hình Console.
        /// </summary>
        /// <param name="text">Chuỗi văn bản cần căn giữa.</param>
        /// <returns>Giá trị của mép cửa sổ Console tới vị trí text bên trái được căn giữa nội dung. </returns>
        public int CenterContent(string text, bool breakLine, int length = 0)
        {
            int screenWidth = Console.WindowWidth;
            int textLength = !text.Equals("") ? text.Length : length;
            int leftMargin = (screenWidth - textLength) / 2;

            if (leftMargin > 0)
            {
                Console.SetCursorPosition(leftMargin, Console.CursorTop);
                if (text != "")
                {
                    if (breakLine)
                    {
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.Write(text);
                    }
                }
                return leftMargin;
            }
            return 0;

        }

        /// <summary>
        /// Đặt con trỏ dòng (x) trên màn hình Console với khoảng trống từ đỉnh màn hình (marginTop).
        /// </summary>
        /// <param name="x">Vị trí cột (x) để đặt con trỏ dòng.</param>
        /// <param name="marginTop">Khoảng trống từ đỉnh màn hình đến vị trí dòng (x).</param>
        public void SetXCursor(int x, int marginTop = 0)
        {
            Console.SetCursorPosition(x, Console.CursorTop + marginTop);
        }
    }
}