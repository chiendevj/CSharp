using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Graph_Theory
{
    public class TienIch_DFS
    {
        /// <summary>
        /// Function tìm Chu trình hoặc đường đi Euler bằng thuật toán DFS 
        /// </summary>
        /// <param name="maTran"></param>
        /// <param name="soDinh"></param>
        public static void findPathDFS(int[][] maTran, int soDinh)
        {
            if (isConnected(maTran, soDinh))
            {
                List<int> path = new List<int>();          // Dùng List để lưu các đỉnh 
                Stack<int> edgeStack = new Stack<int>();   // Sử dụng ngăn xếp để lưu trữ các cạnh

                DFS(maTran, 0, path, edgeStack);           // Bắt đầu từ đỉnh 0 hoặc đỉnh xuất phát của bạn
          
                if (isEulerGraph(maTran))
                {
                    Console.Write((path[0] == (path[path.Count - 1]) ? "Chu trình Euler: " : "Đường đi Euler: "));

                    int count = 0;
                    foreach (var item in path)
                    {  
                        count++;
                        if (path.Count != count)
                        {
                            Console.Write(item + " -> ");
                        }
                        else
                        {
                            Console.Write(item);
                        }
                    }   
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Đồ thị không có đường đi hoặc chu trình Euler.");
                }
            }
            else
            {
                Console.WriteLine("Đồ thị không liên thông!");
            }
        }

        /// <summary>
        /// Kiểm tra xem có phải là đồ thị Euler hay không?
        /// </summary>
        /// <param name="maTran"></param>
        /// <returns></returns>
        private static bool isEulerGraph(int[][] maTran)
        {
            for (int i = 0; i < maTran.Length; i++)
            {
                int degree = 0;
                for (int j = 0; j < maTran[i].Length; j++)
                {
                    degree += maTran[i][j];
                }
                if (degree % 2 != 0)
                {
                    return false;   
                }
            }
            return true;            
        }

        /// <summary>
        /// Thuật toán DFS (Depth First Search)
        /// </summary>
        /// <param name="graph"> Ma trận cần tìm </param>
        /// <param name="vertex"> Đỉnh bắt đầu </param>
        /// <param name="path"> Danh sách lưu đỉnh kề </param>
        /// <param name="edgeStack"> Danh sách lưu cạnh </param>
        private static void DFS(int[][] graph, int vertex, List<int> path, Stack<int> edgeStack)
        {
            path.Add(vertex);

            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[vertex][i] == 1)
                {
                    edgeStack.Push(i);                       // Lưu cạnh vào ngăn xếp
                    graph[vertex][i] = graph[i][vertex] = 0; // Đánh dấu cạnh đã duyệt qua
                    DFS(graph, i, path, edgeStack);
                }
            }
        }

        /// <summary>
        /// Kiểm tra liên thông?
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="soDinh"></param>
        /// <returns></returns>
        private static bool isConnected(int[][] graph, int soDinh)
        {
            // Tạo một mảng boolean để đánh dấu các đỉnh đã được duyệt qua.
            bool[] visited = new bool[soDinh];

            // Chọn một đỉnh xuất phát (ví dụ: đỉnh 0) và thử duyệt toàn bộ đồ thị từ nó.
            lienThong(graph, 0, visited);

            // Kiểm tra xem tất cả đỉnh đã được duyệt qua. Nếu có đỉnh nào không được duyệt, đồ thị không liên thông.
            for (int i = 0; i < soDinh; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }

            // Nếu tất cả các đỉnh đều được duyệt qua, đồ thị là liên thông.
            return true;
        }
        
        /// <summary>
        /// Hàm liên thông đồ thị đưa tất cả các đỉnh để kiểm tra
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="vertex"></param>
        /// <param name="visited"></param>
        public static void lienThong(int[][] graph, int vertex, bool[] visited)
        {
            visited[vertex] = true;

            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[vertex][i] == 1 && !visited[i])
                {
                   lienThong(graph, i, visited);
                    
                }
            }
        }

       // Input ma trận
        /// <summary>
        /// Ịn ma trận
        /// </summary>
        /// <param name="matrix"> Ma trận dầu vào </param>
        public static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Tạo ma trận từ file
        /// </summary>
        /// <returns></returns>
        public static int[][] createMatrix()
        {
            int[][] matrix = new int[0][];


            using (StreamReader sr = new StreamReader("matran.txt"))
            {
                int soDinh = int.Parse(sr.ReadLine());
                matrix = new int[soDinh][];

                for (int i = 0; i < soDinh; i++)
                {
                    matrix[i] = new int[soDinh];
                    string line = sr.ReadLine();

                    string[] str = line.Split(',');
                    for (int j = 0; j < soDinh; j++)
                    {
                        int x = int.Parse(str[j]);
                        matrix[i][j] = x;
                    }
                }
            }
            return matrix;
        }

        /// <summary>
        /// Ghi file 
        /// </summary>
        public static void writeFile()
        {
            int soDinh = 6;
            string line1 = "0,1,1,1,1,0";
            string line2 = "1,0,1,0,0,0";
            string line3 = "1,1,0,0,1,1";
            string line4 = "1,0,0,0,1,0";
            string line5 = "1,0,1,1,0,1";
            string line6 = "0,0,1,0,1,0";

            try
            {
                using (StreamWriter sw = new StreamWriter("matran.txt"))
                {
                    sw.WriteLine(soDinh);
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    sw.WriteLine(line3);
                    sw.WriteLine(line4);
                    sw.WriteLine(line5);
                    sw.WriteLine(line6);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Don't write file!");
                return;
            }

            Console.WriteLine("Write file successfully!");
        }
    }
}

