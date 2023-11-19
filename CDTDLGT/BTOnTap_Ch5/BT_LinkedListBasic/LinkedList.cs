using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LinkedListBasic
{
    internal class LinkedList
    {
        // fields
        private Node _first;
        private Node _last;
        private int _size;


        // properties

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

        // Constructor
        public LinkedList(Node first, Node last, int size)
        {
            _first = first;
            _last = last;
            _size = size;
        }

        public LinkedList()
        {
            this._first = null;
            this._last = null;
            this._size = 0;
        }
        // Method
        public void addFirst(int data)
        {
            Node newNode = new Node(data);
            if (this._first == null)
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

        public void Print()
        {
            if (this._first == null)
            {
                Console.WriteLine("Empty!");
                return;
            }
            else
            {
                Node p = _first;
                while (p != null) 
                {
                    Console.Write(p.Data +"   ");
                    p = p.Next;
                }
            }
            Console.WriteLine();

        }

        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (_first == null)
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

    }
}
