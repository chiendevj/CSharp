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

        // Chèn sau max
      
    }
}