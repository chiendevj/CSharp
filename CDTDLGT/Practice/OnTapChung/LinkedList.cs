using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnTapChung
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

        // constructor
        public LinkedList()
        {
            this._first = null;
            this._last = null;
            this._size = 0;
        }

        // method

        // Print
        public void PrintList()
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                Console.WriteLine(i.Data.toString());
            }
            Console.WriteLine();
        }

        //  Thêm một phần tử vào đầu danh sách: public void/Node AddFirst(NhanVien nv);
        public void AddFirst(NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);
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

        //  Thêm một phần tử vào cuối danh sách: public void/Node AddLast(NhanVien nv);
        public void AddLast(NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);
            if ( _size == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        //  Tìm kiếm một phần tử theo mã nhân viên: public Node Find(string maNV);
        public Node Find(string maNV)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.MaNV.Equals(maNV))
                {
                    return i;
                }
            }
            return null;
        }

        public NhanVien FindNV(string maNV)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.MaNV.Equals(maNV))
                {
                    return i.Data;
                }
            }
            return null;
        }

        //  Thêm một phần tử sau một phần tử khác trong danh sách: public void/Node AddAfter(Node pre, NhanVien nv);
        public void AddAfter(Node pre, NhanVien nv)
        {
            if (pre != null)
            {
                Node newNode = new Node(nv);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
                _size++;
            }
            
        }

        //  Thêm một phần tử trước một phần tử khác trong danh sách: public void/Node AddBefore(Node pre, NhanVien nv);
        public void AddBefore(Node p, NhanVien mh)
        {
            // P khác null thì mới ADD, p = null sẽ xuất thông báo or nhập đến khi p != null;
            if (p!= null)
            {
                Node newNode = new Node(mh);
                if (p == _first)
                {
                    newNode.Next = _first;
                    _first = newNode;
                    _size++;
                }
                else
                {
                    Node newBefore = _first;
                    while (newBefore.Next != p)
                    {
                        newBefore = newBefore.Next;
                    }
                    newNode.Next = newBefore.Next;
                    newBefore.Next = newNode;
                    _size++;
                }

            }                                      
            
        }

        // Interchangesort
        public void InterchangeSort()
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                for (Node p = i.Next; p != null; p = p.Next)
                {
                    if (i.Data.TuoiNV < p.Data.TuoiNV)
                    {
                        NhanVien temp;
                        temp = i.Data;
                        i.Data = p.Data;
                        p.Data = temp;
                    }
                }
            }            
        }

        // selectionsort
        public void SelectionSort()
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                Node min = i;
                for (Node p = i.Next; p != null; p = p.Next)
                {
                    if (p.Data.TenNV.CompareTo(min.Data.TenNV) > 0)
                    {
                        min = p;
                    }
                }
                    NhanVien temp;
                    temp = i.Data;
                    i.Data = min.Data;
                    min.Data = temp;
            }
        }

        // Remove First
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
                _size--;
            }
        }

        // Remove Last
        public void RemoveLast()
        {
            if (_first == _last)
            {
                _first = null;
                _last = null;
                _size = 0;

            }
            else
            {
                Node pre = _first;
                while (pre.Next != _last)
                {
                    pre = pre.Next;
                }
                pre.Next = null;
                _last = pre;
                _size--;
            }
        }
        //xoa mot phan tu sau 1 node
        public Node RemoveAfter(Node pre)
        {
            if (pre != null && pre == _last)
            {
                Node del = pre.Next;
                pre.Next = pre.Next.Next;
                _size--;
                return del;
            }

            return null;
        }

        //xoa 1 phan tu truoc 1 node
        public Node RemoveBefore(Node p)
        {
            Node temp = new Node(new NhanVien());
            if (p != null && p != _first) //co it nhat 2 phan tu
            {
                if (_first.Next == p) //xoa first
                {
                    temp = _first;
                    _first = p;
                    _size--;
                }
                else
                {
                    Node pre = _first;
                    for (; pre.Next.Next != p; pre = pre.Next)
                    {
                        //dung truoc p 2 Node
                    }

                    temp = pre.Next;

                    pre.Next = p;
                    _size--;
                }

                return temp;
            }

            return null;
        }

        //xoa 1 phan tu dua vao node
        public Node Remove(Node p)
        {
            Node temp = new Node(new NhanVien());
            if (p != null)
            {
                if (p == _first)
                {
                    temp = _first;
                    _first = _first.Next;
                    _size--;
                }
                else if (p == _last)
                {
                    temp = _last;
                    Node pre = _first;
                    for (; pre.Next != _last; pre = pre.Next)
                    {
                        // pre dung truoc last
                    }

                    pre.Next = null;
                    _last = pre;
                    _size--;
                }
                else
                {
                    temp = p;
                    Node pre = _first;
                    for (; pre.Next != p; pre = pre.Next)
                    {
                        // pre dung truoc p
                    }

                    pre.Next = p.Next;
                    _size--;
                }

                return temp;
            }

            return null;
        }

        // Remove gia tri
        public void Remove(NhanVien nv)
        {
            Node del = Find(nv.MaNV);
            if (del != null)
            {
                if (del == _first) //Xoa dau
                {
                    _first = _first.Next;
                    if (_first == null)
                    {
                        _last = null;
                    }
                }
                else //Cuoi hoac giua
                {
                    Node p = _first;
                    while (p.Next != del)
                    {
                        p = p.Next;
                    }
                    p.Next = del.Next;
                    if (del == _last)
                    {
                        _last = p;
                    }
                }
                _size--;
            }
        }

    }
}
