using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Ch5
{
    class Stack
    {
        // fields
        private Node _top; // first
        private int _size;

        // properties
        internal Node Top
        {
            get
            {
                return _top;
            }

            set
            {
                _top = value;
            }
        }

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

        public Stack()
        {
            this.Top = null;
            this.Size = 0;
        }

        // Method
        public void Display()
        {
            for (Node p = _top; p != null; p=p.Next)
            {
                Console.Write(p.Data);
            }
            Console.WriteLine();
        }

        public int Pop() // RemoveFirst, co tra ve so bi xoa
        {
            if (_top == null)
            {
                throw new Exception("Empty!!");
            }
            else
            {
                int value = _top.Data;
                _top = _top.Next;
                _size--;
                return value;
            }
        }

        public void Push(int data) // AddFirst
        {
            Node pNew = new Node(data);
            if (_top == null)
            {
                _top = pNew;
            }
            else
            {
                pNew.Next = _top;
                _top = pNew;
            }
            _size++;
        }


    }
}
