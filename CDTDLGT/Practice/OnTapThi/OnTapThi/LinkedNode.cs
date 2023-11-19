using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTapThi
{
    public class LinkedList
    {
        //fields
        private Node _first;
        private Node _last;
        private int _count;

        //properties
        public Node First { get => _first; set => _first = value; }
        public Node Last { get => _last; set => _last = value; }
        public int Count { get => _count; set => _count = value; }

        //constructors
        public LinkedList() //rong
        {
            _first = null; 
            _last = null;
            _count = 0;
        }

        //methods
        // Print 
        public void Print()
        {
            for (Node i = _first; i != null; i = i.Next) // chay lan cuoi la _last length-1 != _last
            {
                Console.WriteLine(i.Data.toString());
            }
        }

        // Ham TIm vi tri index
        public Node Find(String manv) 
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.MaNhanVien.Equals(manv))
                {
                    return i;
                }
            }
            return null;
        }

        // Ham Tim Nhan Vien
        public NhanVien FindNV(String manv)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.MaNhanVien.Equals(manv))
                {
                    return p.Data;
                }
            }
            return null;
        }
        public void AddFirst(NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);

            if (_count == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _count++;
        }

        public void AddLast(NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);

            if (_count == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _count++;
        }

        public void AddAfter(Node pre, NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);

            if (pre != _last) // add Last
            {
                _last.Next = newNode;
                _last = newNode;
            }
            else
            {
                pre.Next = newNode.Next;
                pre.Next = newNode;
            }
            _count++;
        }

        public void AddBefore(Node p, NhanVien nvThem)
        {
            Node newNode = new Node(nvThem);
            if (p != null)
            {
                if (p == _first) //add first
                {
                    newNode.Next = _first;
                    _first = newNode;
                }
                else
                {
                    newNode.Next = p;

                    Node pre = _first; // node truoc p
                    for (; pre.Next !=  p ; pre = pre.Next) // truoc p 
                    {
                        // pre.Next = p;
                    }
                    pre.Next = newNode;
                }
                _count++;
            }
        }

        // REMOVE
        public void RemoveFirst()
        {
            if (_count == 0)
            {
                Console.WriteLine("Khong xoa duoc do danh sach rong");
            }
            else //co phan tu
            {
                if (_count == 1) //dua ve trang thai rong
                {
                    _first = null;
                    _last = null;
                    _count = 0;
                }
                else //co nhieu phan tu
                {
                    _first = _first.Next;
                    _count--;
                }
            }
        }

        public void RemoveLast()
        {
            if (_count == 0)
            {
                Console.WriteLine("Khong xoa duoc do danh sach rong");
            }
            else
            {
                if (_count == 1)
                {
                    _first = null;
                    _last = null;
                    _count = 0;
                }
                else
                {
                    Node pre = _first;
                    for (; pre.Next != _last  ; pre= pre.Next) //dung truoc
                    {
                        // pre.Next = _last;
                    }
                    _last = pre;
                    _last= null;
                    _count--;
                }
            }
        }

        public void RemoveAfter(Node p)
        {
            if (p != null && p.Next != null)
            {
                if (p.Next == _last)
                {
                    Node pre = _first;
                    for (; pre.Next != _last; pre= pre.Next)
                    {

                    }
                    _last = pre;
                    _last.Next = null;
                }
                else
                {
                    p.Next = p.Next.Next;
                }
                _count--;
            }
        }

        public void RemoveBefore(Node p)
        {
            if (p!= null && p != _first)
            {
                if (p == _first.Next)
                {
                    _first = p;
                }
                else
                {
                    Node pre = _first;
                    for (; pre.Next.Next != p; pre= pre.Next) //phan tu truoc truoc p
                    {

                    }

                    pre.Next = p;
                }
                _count--;
            }
        }

        public void Remove(string maNV)
        {
            Node p = Find(maNV);
            if (p != null)
            {
                if (p == _first)
                {
                    _first = _first.Next;
                }
                else if (p == _last)
                {
                    Node pre = _first;
                    for (; pre.Next != _last; pre = pre.Next)
                    {

                    }

                    _last = pre;
                    _last.Next = null;
                }
                else
                {
                    Node pre = _first;
                    for (; pre.Next != p; pre = pre.Next)
                    {

                    }

                    pre.Next = p.Next;
                }

                _count--;
            }
        }
        public void Remove(Node p)
        {
            if (p != null)
            {
                if (p == _first)
                {
                    _first = _first.Next;
                }
                else if (p == _last)
                {
                    Node pre = _first;
                    for (; pre.Next != _last; pre=pre.Next)
                    {

                    }

                    _last= pre;
                    _last.Next = null;
                }
                else
                {
                    Node pre = _first;
                    for (; pre.Next != p; pre = pre.Next)
                    {

                    }

                    pre.Next = p.Next;
                }

                _count--;
            }
        }

        // SORT
        public void Swap(ref NhanVien a,ref  NhanVien b) 
        {
            NhanVien temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void InterChangeSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data.MaNhanVien.CompareTo(q.Data.MaNhanVien) > 0)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
        }

        public void SelectionSort()
        {
           
            for (Node p = _first; p != null; p = p.Next)
            {
                Node min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data.MaNhanVien.CompareTo(q.Data.MaNhanVien) > 0)
                    {
                        min = q;
                    }
                }
                    Swap(ref p.Data, ref min.Data);
            }
        }
    }
}