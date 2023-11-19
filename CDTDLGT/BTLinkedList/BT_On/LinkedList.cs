using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_On
{
    class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;

        public int Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }

        internal Node First
        {
            get
            {
                return _first;
            }

            set
            {
                _first = value;
            }
        }

        internal Node Last
        {
            get
            {
                return _last;
            }

            set
            {
                _last = value;
            }
        }

        public LinkedList(Node _first, Node _last, int _size)
        {
            this._first = _first;
            this._last = _last;
            this._size = _size;
        }

        public LinkedList()
        {

        }

        // method
        // THEM VAO DAU DANH SACH
        public void AddFirst(MonHoc mh)
        {
            Node newNode = new Node(mh);
            if (_first == null)
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

        // IN DANH SACH
        public void PrintList()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.WriteLine(p.mh.toString());
            }
        }

        // TIM MA MON HOC
        public Node FindMaMH(string maMH)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.mh.MaMonHoc.CompareTo(maMH) == 0)
                {
                    return p;
                }
            }
            return null;
        }

        // HOAN VI
        public void Swap(ref MonHoc mh1,ref MonHoc mh2)
        {
            MonHoc mhTam = mh1;
            mh1 = mh2;
            mh2 = mhTam;
        }
        
        // SAP XEP 
        public void InterchangeSor()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node t = _first; t != null; t = t.Next)
                {
                    if (p.mh.MaMonHoc.CompareTo(t.mh.MaMonHoc) > 0)
                    {
                    Swap(ref p.mh, ref t.mh);
                    }
                }
            }
        }

        // THEM SAU MOT PHAN TU
        public void AddAfter(Node pre, MonHoc mh)
        {
            if (pre != null)
            {
                Node newNode = new Node(mh);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
                _size ++;
            }
        }

        // XOA SAU MOT PHAN TU
        public void RemoveAfter(Node pre)
        {
            if (pre != null && pre != _last)
            {
                Node del = pre.Next;
                pre.Next = del.Next;

                if (del == _last)
                {
                    _last = pre;
                }
                _size--;
            }
        }
    }
}
