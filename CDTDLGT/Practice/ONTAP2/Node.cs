using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP2
{
    internal class Node
    {
        // field
        internal MonHoc Data;
        internal Node Next;

        // constructor
        public Node(MonHoc data)
        {
            Data = data;
            Next = null;
        }
    }
}
