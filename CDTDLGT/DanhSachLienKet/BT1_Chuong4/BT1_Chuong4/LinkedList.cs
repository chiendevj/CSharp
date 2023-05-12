using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_Chuong4
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

        // method
        
        // AddAfter
        public void AddAfter(Node pre, int data)
        {
            if (pre != null)
            {
                Node newNode = new Node(data);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                }
                _size--;
            }
            
        }
        // In

        public void PrintList()
        {
            if (_first == null)
            {
                Console.WriteLine("Empty!");
                return;
            }

            Node p = _first;
            while (p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
            Console.WriteLine();
        }

        // Thêm vào cuối
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (_first == null) //  Danh sach dang rong
            {
                _first = newNode;
                _last = newNode;
            }
            else // Danh sach da co du lieu
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        public void AddAfter()
        {

        }
    }
}
