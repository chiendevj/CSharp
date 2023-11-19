using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapChung
{
    internal class Node
    {
        // fields
        internal NhanVien Data;
        internal Node Next;

        // Constructor
        public Node(NhanVien data) 
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
