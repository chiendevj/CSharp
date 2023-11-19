using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOnTap_Ch5
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
            this._first = null;
            this._last = null;
            this._size = 0;
        }

        // Method
        // ADD
        public void AddFirst(NhanVien nv)
        {
            Node newNode = new Node(nv);
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

        public void AddLast(NhanVien nv)
        {
            Node pNew = new Node(nv);
            if (_last == null)
            {
                _first = pNew;
                _last = pNew;
            }
            else
            {
                pNew.Next = _last;
                _last = pNew;
            }
            _size++;
        }

        public void AddAfter(Node pre, NhanVien nv)
        {
            Node newNode = new Node(nv);
            if (pre != null)
            {
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
            }
            _size++;
        }

        //public void AddBefore(Node pre, NhanVien nv)
        //{
        //    Node newNode = new Node(nv);
        //    if (pre != null)
        //    {
        //        newNode.Next = pre;
        //        pre.Next = newNode;
        //        if (pre == _first)
        //        {
        //            _first = newNode;
        //        }
        //    }
        //    _size++;
        //}

        // FIND
        public Node Find(string maNV)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.MaNV == maNV)
                {
                    return p;
                }
            }
            return null;
        }

        // REMOVE
        public void RemoveFirst()
        {
            Node p = _first;
            if (p != null)
            {
                _first = p.Next;
                if (_first == null)
                {
                    _last = null;
                }
            }
            _size--;
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

        public Node Remove1(string maNV)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.MaNV == maNV)
                {
                    return p;
                }
            }
            return null;
        }
        public void RemoveAfter(Node del, NhanVien nv)
        {
            Node p = new Node(nv);

        }
        public void InterchangeSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data.TuoiNV > q.Data.TuoiNV)
                    {
                        Swap(p.Data,q.Data);
                    }
                }
            }
        }
        public void SelectionSort()
        {
            Node min;
            for (Node p = _first; p!= null; p=p.Next)
            {
                min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (min.Data.TuoiNV < q.Data.TuoiNV)
                    {
                        Swap(min.Data,q.Data);
                    }
                }
            }
        }
        public void Swap(NhanVien a, NhanVien b)
        {
            NhanVien c;
            c = a;
            a = b;
            b = c;
        }


    }
    
}

