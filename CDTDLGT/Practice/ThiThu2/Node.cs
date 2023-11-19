using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu2
{
    internal class Node
    {
        internal GiayDep Data;
        internal Node Next;

        public Node(GiayDep data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
