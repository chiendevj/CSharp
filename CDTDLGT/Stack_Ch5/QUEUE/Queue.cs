using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    class Queue
    {
        private Node _first, _last;
        private int _size;

        // Con
        public Queue()
        {
            this.First = null;
            this.Last = null;
            this.Size = 0;
        }

        // Pro
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

        // Method
        public void EnQueue(HangHoa data)
        {
            Node pNew = new Node(data);
            if (_first == null)
            {
                _first = pNew;
                _last = pNew;
            }
            else
            {
                _last.Next = pNew;
                _last = pNew;
            }
            _size++;
        }

        public HangHoa DeQueue()
        {
            if (_first == null)
            {
                throw new Exception("Empty!");
            }
            else
            {
                HangHoa value = _first.Data;
                _first = _first.Next;
                if (_first == null)
                {
                    _last = null;
                }
                _size--;
                return value;
            }
        }

        public HangHoa Peek()
        {
            if (_first == null)
            {
                throw new Exception("Empty!");
            }
            else
            {
                HangHoa value = _first.Data;
                return value;
            }
        }


    }

}
