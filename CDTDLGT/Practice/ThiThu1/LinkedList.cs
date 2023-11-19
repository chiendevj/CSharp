using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
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
        // - AddLast(HangHoa hh): Thêm một phần tử vào cuối danh sách.
        public void AddLast(MonHoc mh)
        {
            Node newNode = new Node(mh);
            if (_size == 0)
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

        // - Find(string maHang): Tìm kiếm một phần tử trong danh sách theo mã hàng.
        public Node Find(string maHang)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.Ma.Equals(maHang))
                {
                    return i;
                }
            }
            return null;
        }

        // - InterchangeSort(): Sắp xếp danh sách giảm dần theo giá bán.
        public void InterchangeSort()
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                for (Node p = i.Next; p != null; p = p.Next)
                {
                    if (i.Data.SoTC > p.Data.SoTC)
                    {
                        MonHoc temp;
                        temp = i.Data;
                        i.Data = p.Data;
                        p.Data = temp;
                    }
                }
            }

        }
        // - AddBefore(Node pre, HangHoa hh): Thêm một phần tử vào truoc một phần tử khác trong danh sách.
        public void AddFirst(MonHoc mh)
        {
            Node newNode = new Node(mh);
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

        public void AddBefore(Node  p, MonHoc mh)
        {
            if (p != null)
            {
                if (p == _first)
                {
                    AddFirst(mh);
                }
                else
                {
                    Node newNode = new Node(mh);
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

        // - AddAfter(Node pre, HangHoa hh): Thêm một phần tử vào sau một phần tử khác trong danh sách.
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
                _size++;
            }
        }

        // - RemoveFirst(): Xóa một phần tử đầu danh sách.
        public void RemoveAfter(Node pre)
        {
            if (pre != _last && pre != null)
            {
                Node del = pre.Next;
                if (pre.Next == _last)
                {
                    pre.Next = null;
                    _last = pre;
                    _size--;
                }
                else
                {
                    pre.Next.Next = del;
                    _size--;
                }
            }
        }

        //

    }
}
