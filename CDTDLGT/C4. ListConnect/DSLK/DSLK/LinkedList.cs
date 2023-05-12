using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    class LinkedList
    {
        // fields
        private Node _first, _last;
        private int _size;

        // Constructor
        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        // properties
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
        
        // method
        public void PrintList()
        {
            if (this._first == null)
            {
                Console.WriteLine("LinkedList is empty!");
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


        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (_first == null)   // DS Rong (_size == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else // DS co du lieu
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (_first == null)   // DS Rong (_size == 0)
            {
                _first = newNode;
                _last = newNode;
            }
            else // DS co du lieu
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        public Node Find(int data)  // SequenceSearch
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == data)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddAfter(Node pre, int data)
        {
            if (pre != null)
            {
                Node newNode = new Node(data);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last) // pre la node cuoi.
                {
                    _last = newNode;
                }
                _size++;
            }
        }

        public Node FindMax()  // SequenceSearch
        {
            Node max = _first;
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == Data)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
