using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToMauDoThi
{
    internal class Test_DoThi
    {
        static void Main(string[] args)
        {
            TienIch_DoThi.GhiFile();
            int[][] matrix = TienIch_DoThi.TaoMaTran();
            TienIch_DoThi.InMaTran(matrix);

            Console.WriteLine(TienIch_DoThi.timBacCuaDinhLonNhat(matrix));
        }
    }
}
