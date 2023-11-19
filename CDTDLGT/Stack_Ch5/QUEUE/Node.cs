using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    class Node
    {
        internal HangHoa Data;
        internal Node Next;

        public Node(HangHoa data)
        {
            Data = data;
            Next = null;
        }
    }
}
