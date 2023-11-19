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
    class DrawTable
    {
        /// <summary>
        /// Vẽ bảng và căn giữa bảng.
        /// </summary>
        /// <param name="col">Số cột của bảng</param>
        /// <param name="colLengths">Danh sách độ dài cột theo thứ tự từ cột thứ 1 - hết</param>
        /// <param name="colLabels">Danh sách tiêu đề cột theo thứ tự từ cột thứ 1 - hết</param>
        /// <param name="colValues">Danh sách giá trị cho các hàng</param>
        public DrawTable(int col, List<int> colLengths, List<string> colLabels, List<string> colValues)
        {
            int length = 0;
            foreach (var item in colLengths)
            {
                length += item;
            }
            Utility uitl = new Utility();
            int center = uitl.CenterContent("", true, length);
            uitl.SetXCursor(center);
            // Draw line top title
            Console.ForegroundColor = Color.aroundTableColor;
            Console.Write("+");
            for (int i = 0; i < colLengths.Count(); i++)
            {
                int currentCross = colLengths[i];
                for (int j = 0; j < currentCross; j++)
                {
                    if (j == currentCross - 1)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }

            // Break Line
            Console.WriteLine();

            // Draw title
            uitl.SetXCursor(center);
            Console.Write("|");
            for (int i = 0; i < colLengths.Count(); i++)
            {
                int currentCross = colLengths[i];
                for (int j = 0; j < currentCross; j++)
                {
                    if (j == currentCross - 1)
                    {
                        Console.ForegroundColor = Color.aroundTableColor;
                        Console.Write("|");
                    }
                    else if (j == 0)
                    {
                        int space = (currentCross - colLabels[i].Length) / 2; // khoảng cách chiếm khi thụt đầu dòng
                        int content = currentCross - 1; // khoảng cách chiếm của nội dung
                        Console.ForegroundColor = ConsoleColor.White;
                        string formattedLabel = string.Format("{0," + -1 * (content - space) + "}", colLabels[i]);
                        string formattedSpace = string.Format("{0," + 1 * (space) + "}", "");
                        Console.ForegroundColor = Color.titleTableColor;
                        Console.Write($"{formattedSpace}{formattedLabel}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            // Break Line
            Console.WriteLine();

            // Draw line bottom title
            uitl.SetXCursor(center);
            Console.Write("+");
            for (int i = 0; i < colLengths.Count(); i++)
            {
                int currentCross = colLengths[i];
                for (int j = 0; j < currentCross; j++)
                {
                    if (j == currentCross - 1)
                    {
                        Console.ForegroundColor = Color.aroundTableColor;
                        Console.Write("+");
                    }
                    else
                    {
                        Console.ForegroundColor = Color.aroundTableColor;
                        Console.Write("-");
                    }
                }
            }

            // Break Line
            Console.WriteLine();

            // Draw value
            for (int z = 0; z < colValues.Count();)
            {
                uitl.SetXCursor(center);
                Console.Write("|");
                for (int i = 0; i < col; i++)
                {
                    int currentCross = colLengths[index: i];
                    for (int j = 0; j < currentCross; j++)
                    {
                        if (j == currentCross - 1)
                        {
                            Console.ForegroundColor = Color.aroundTableColor;
                            Console.Write("|");
                        }
                        else if (j == 0)
                        {
                            // space
                            int space = (currentCross - colValues[z].Length) / 2;
                            int content = currentCross - 1;
                            // color
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            string formattedLabel = string.Format("{0," + -1 * (content - space) + "}", colValues[z]);
                            string formattedSpace = string.Format("{0," + 1 * space + "}", "");
                            Console.ForegroundColor = Color.textTableColor;
                            Console.Write($"{formattedSpace}{formattedLabel}");
                            z++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                Console.WriteLine();
            }

            // Break Line
            uitl.SetXCursor(center);
            Console.Write("+");
            // Draw line bottom title
            for (int i = 0; i < colLengths.Count(); i++)
            {
                int currentCross = colLengths[i];
                for (int j = 0; j < currentCross; j++)
                {
                    if (j == currentCross - 1)
                    {
                        Console.ForegroundColor = Color.aroundTableColor;
                        Console.Write("+");
                    }
                    else
                    {
                        Console.ForegroundColor = Color.aroundTableColor;
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}