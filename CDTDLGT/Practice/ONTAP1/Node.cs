using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP1
{
    internal class Node
    {
        // field
        internal HangHoa Data;
        internal Node Next;

        // Constructor
        public Node(HangHoa data) 
        {
            Data = data;
            Next = null;
        }
    }
}
