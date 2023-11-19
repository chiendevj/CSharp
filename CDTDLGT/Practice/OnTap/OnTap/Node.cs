using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Node
    {
        internal HangHoa Data;
        internal Node Next;

        public Node(HangHoa value)
        {
            this.Data = value;
            this.Next = null;
        }
    }
}
