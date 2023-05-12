using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BT_C4
{
    class LinkedList
    {
        //Fields
        private Node _first;
        private Node _last;
        private int _size;

        //Propesties
        public int Count
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

        //Constructor
        public LinkedList()
        {
            this._first = null;
            this._last = null;
            this._size = 0;
        }

        //Methods
        public void PrintList()
        {
            if(_first == null)
            {
                Console.WriteLine("Empty!");
                return;
            }

            Node p = _first;
            while(p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
            Console.WriteLine();
        }

        //
        public void AddFist(int data)
        {
            Node newNode = new Node(data);
            if (_first == null) //Danh sach dang rong
            {
                _first = newNode;
                _last = newNode;
            }
            else //Danh sach da co du lieu
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (_first == null) //Danh sach dang rong
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

        // Tìm vị trí node
        public Node Find(int data)
        {
            for(Node p = _first; p!= null; p = p.Next)
            {
                if (p.Data == data)
                {
                    return p;// trả về node tìm được
                }
            }
            return null;
        }

        // Chèn  sau 
        public void AddAfter(Node pre, int data)
        {
            if(pre != null)
            {
                Node newNode = new Node(data);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if(pre == _last) //pre la con tro cuoi
                {
                    _last = newNode;
                }
                _size++;
            }
        }

        public void AddBefore(Node pre, int data)
        {
            if (pre != null)
            {
                Node pnew = new Node(data);
                if (pre == _first)
                {
                    pnew.Next = _first;
                    _first = pnew;
                }
                else
                {
                    Node p = _first;
                    while (p.Next != pre)
                    {
                        p = p.Next;
                    }
                    // Con tro p dang tro den node truoc con tro pre

                    pnew.Next = p.Next;
                    p.Next = pnew;


                }
                _size++;
            }
        }
      
        public void RemoveFirst()
        {
            if (_first != null)
            {
                _first = _first.Next;
                if (_first == null)
                {
                    _last = null;
                }
                _size--;
            }
        }

        public void RemoveLast()
        {
            if (_first != null) // Con tro khac null thi moi xoa
            {
                if (_first == _last)
                {
                    _first = null;
                    _last = null;
                    _size = 0;
                }
                else
                {
                    Node p = _first;
                    while (p.Next != _last)
                    {
                        p = p.Next;
                    }

                    p.Next = null;
                    _last = p;
                    _size--;
                }
            }
        }

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

        public void Remove(int data)
        {
            Node del = Find(data);
            if (del != null)
            {
                if (del == _first) // Xoa dau neu remove first khong can size--
                {
                    _first = _first.Next;
                    if (_first == null)
                    {
                        _last = null;
                    }
                }
                else// Xoa giua va cuoi
                {
                    Node p = _first;
                    while (p.Next != del)
                    {
                        p = p.Next;
                    }

                    p.Next = del.Next;
                    // Kiem tra LAst
                    if (del == _last)
                    {
                        _last = p;
                    }
                }
                
                _size--;
            }
        }

        public void Remove(Node del)    // Truyen con tro
        {
            if (del != null)
            {
                if (del == _first) // Xoa dau neu remove first khong can size--
                {
                    _first = _first.Next;
                    if (_first == null)
                    {
                        _last = null;
                    }
                }
                else// Xoa giua va cuoi
                {
                    Node p = _first;
                    while (p.Next != del)
                    {
                        p = p.Next;
                    }

                    p.Next = del.Next;
                    // Kiem tra LAst
                    if (del == _last)
                    {
                        _last = p;
                    }
                }

                _size--;
            }
        }

        public void Clear() // Xoa toan bo danh sach
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void InterchangeSort()
        {
            for (Node p = _first; p.Next != null; p = p.Next)
            {
                for (Node q = p.Next;q != null; q = q.Next)
                {
                    if (p.Data < q.Data)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
        }

        public void SelectionSort()
        {
            for (Node p = _first; p.Next != null; p = p.Next)
            {
                Node min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (q.Data < min.Data)
                    {
                        min = q;
                    }
                }
                Swap(ref min.Data, ref p.Data);
            }
        }

       

    }
}