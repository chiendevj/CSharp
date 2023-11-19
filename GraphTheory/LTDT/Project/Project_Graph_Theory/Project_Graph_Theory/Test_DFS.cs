using Project_Graph_Theory;
using System;
using System.Collections.Generic;

namespace Project_Graph_Theory
{
    class Test_DFS
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Test case 1
            TienIch_DFS.writeFile();
            int[][] graph = TienIch_DFS.createMatrix();
            TienIch_DFS.printMatrix(graph);
            int soDinh = graph.GetLength(0);
            TienIch_DFS.findPathDFS(graph, soDinh);

            
        }
    }
}
