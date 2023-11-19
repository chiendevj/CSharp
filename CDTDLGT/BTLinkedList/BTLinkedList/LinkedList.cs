using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinkedList
{
    class LinkedList
    {
        // fews
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
        // Method
        public void AddLast(SinhVien Data)
        {
            Node newNode = new Node(Data);
            if (_first == null)
            {
                _first = newNode;
                _last = newNode;

            }
            else //Danh sach da co du lieu
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        public Node FindMaSV(string key)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.MaSV == key)
                {
                    return p;// trả về node tìm được
                }
            }
            return null;
        }

        public void Swap(ref SinhVien sv1, ref SinhVien sv2)
        {
            SinhVien svTam = sv1;
            sv1 = sv2;
            sv2 = svTam;
        }
        public void SelectionSort()
        {
            Node min;
            for (Node p = _first; p.Next != null; p=p.Next)
            {
                min = p;
                for (Node t = _first; t.Next != null; t = t.Next)
                {
                    if (p.Data.MaSV.CompareTo(t.Data.MaSV) > 0)
                    {
                        min = t;
                    }
                    Swap(ref min.Data, ref t.Data);
                }
            }
        }

        public void Remove(Node del)
        {
            if (del != null)
            {
                if (del == _first)
                {
                    _first = _first.Next;
                    if (_last == null)
                    {
                        _last = null;
                    }
                    else // Xoa giua va cuoi
                    {
                        Node pre = _first;
                        while (pre.Next != del)
                        {
                            pre = pre.Next;
                        }
                    
                        // con tro pre dung lien truoc con tro del
                        pre.Next = del.Next;
                        if (del == _last) // con tro dang quan li node cuoi
                        {
                            _last = pre;
                        }

                    }
                    _size--;
                }
            }
        }
    }
}
