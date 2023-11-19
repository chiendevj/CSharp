using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class LinkedList
    {
        //fields
        private Node _first;
        private Node _last;
        private int _count;

        //properties
        public int Size { get => _count; set => _count = value; }
        internal Node First { get => _first; set => _first = value; }
        internal Node Last { get => _last; set => _last = value; }

        //constructors
        public LinkedList()
        {
            this._count = 0;
            this._first = null;
            this._last = null;
        }

        //methods
        public void AddLast(HangHoa hangHoa)
        {
            Node newNode = new Node(hangHoa);

            if (_first == null)
            {
                _first = newNode;
                _last= newNode;
                _count++;
                return;
            }

            _last.Next= newNode;
            _last = newNode;

            this._count++;

        }

        public Node Find(string ma)
        {
            for (Node i = _first; i != null ; i = i.Next)
            {
                if (i.Data.MaHang.Equals(ma))
                {
                    return i;
                }
            }

            return null;
        }

        public LinkedList InterchangeSort()
        {
            LinkedList sub = new LinkedList();

            for (Node i = _first; i != null; i = i.Next)
            {
                sub.AddLast(i.Data);
            }

            for (Node i = sub._first; i != sub._last; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (i.Data.GiaBan < j.Data.GiaBan)
                    {
                        HangHoa temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }

            return sub;
        }

        public void AddAfter(Node pre, HangHoa hangHoa)
        {
            if (pre != null)
            {
                if (pre == _last)
                {
                    AddLast(hangHoa);
                    return;
                }

                Node newNode = new Node(hangHoa);
                newNode.Next = pre.Next;
                pre.Next = newNode;

                this._count++;

            }
        }

        public void RemoveFirst()
        {
            if (_first == null)
            {
                throw new Exception("Danh sach rong");
            }

            if (_first == _last)
            {
                _first = null;
                _last= null;
                _count--;
                return;
            }

            _first = _first.Next;
            _count--;
        }
    }
}
