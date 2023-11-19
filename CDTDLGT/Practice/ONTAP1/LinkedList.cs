using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP1
{
    internal class LinkedList
    {
        // fields
        private Node _first;
        private Node _last;
        private int _size;

        // properties
        public int Size { get => _size; set => _size = value; }
        internal Node First { get => _first; set => _first = value; }
        internal Node Last { get => _last; set => _last = value; }

        // Constructor
        public LinkedList() 
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        // Method
        // AddFirst
        public void AddFirst(HangHoa hh)
        {
            Node newNode = new Node(hh);

            if (_size == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }

        // Find trả về Node
        public Node Find(string ma) 
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.MaHang.Equals(ma))
                {
                    return i;
                }
            }
            return null;
        }

        // Find trả về HH
        public HangHoa FindHH(string ma)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.MaHang.Equals(ma))
                {
                    return i.Data;
                }
            }
            return null;
        }

        // InterchangeSort
        public void Swap(ref HangHoa hh1, ref HangHoa hh2)
        {
            HangHoa temp;
            temp = hh1;
            hh1 = hh2;
            hh2 = temp;
        }

        public void Selection()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Node min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data.GiaBan.CompareTo(q.Data.GiaBan) > 0)
                    {
                        min = q;
                    }
                }
                Swap(ref min.Data, ref p.Data);
            }
        }
        public void Interchange()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data.GiaBan.CompareTo(q.Data.GiaBan) < 0)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
        }

        // AddAfter(Node pre, MonHoc mh): Thêm một phần tử vào sau một phần tử khác trong danh sách.
        public void AddAfter(Node pre, HangHoa hh)
        {
            if (pre != null)
            {
                Node newNode = new Node(hh);
                newNode.Next =  pre.Next;
                pre.Next = newNode;
                if (_last == null)
                {
                    _last = newNode;
                }
            }
            _size++;
        }

        // RemoveFirst
        public void RemoveFirst()
        {
            if (_size == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else if (_size == 1)
            {
                _first = null;
                _last = null;
                _size = 0;
            }
            else
            {
                _first = _first.Next;
            }
            _size--;
        }
    
    }
}
