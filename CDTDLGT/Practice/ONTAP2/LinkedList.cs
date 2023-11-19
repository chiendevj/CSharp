using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP2
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
            _first = null;
            _last = null;
            _size = 0;
        }

        // method
        // - AddLast(MonHoc mh) : Thêm một phần tử vào đầu danh sách.
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

        // - Find(string maMH): Tìm kiếm một phần tử trong danh sách theo mã môn học.
        public MonHoc Find(string maMH)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.Ma.Equals(maMH))
                {
                    return i.Data;
                }
            }
            return null;
        }

        // - InterchangeSort():Sắp xếp danh sách tăng dần theo số tín chỉ.
        public void Swap(ref MonHoc sb1, ref MonHoc sb2)
        {
            MonHoc temp;
            temp = sb1;
            sb1 = sb2;
            sb2 = temp;
        }

        public void InterchangeSort()
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (i.Data.SoTC.CompareTo(j.Data.SoTC) > 0)
                    {
                        Swap(ref i.Data, ref j.Data);
                    }
                }
            }
        }

        // - AddAfter(Node pre, MonHoc mh): Thêm một phần tử vào sau một phần tử khác trong danh sách.
        public Node FindNode(string maMH)
        {
            for (Node i = _first; i != null; i = i.Next)
            {
                if (i.Data.Ma.Equals(maMH))
                {
                    return i;
                }
            }
            return null;
        }

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
            }
            _size++;
        }

        // ADDBEFORE
        public void AddBefore(MonHoc newData, MonHoc mh)
        {
            Node newNode = new Node(newData);

            if (_first == null)
            {
                // Danh sách liên kết đơn rỗng, thêm phần tử mới làm đầu danh sách
                _first = newNode;
                return;
            }

            if (_first.Data.Equals(mh))
            {
                // Phần tử muốn thêm mới sẽ làm đầu danh sách
                newNode.Next = _first;
                _first = newNode;
                return;
            }

            Node pre = _first;
            while (pre.Next != null)
            {
                if (pre.Next.Data.Equals(mh))
                {
                    // Thêm phần tử mới vào trước phần tử có giá trị existingData
                    newNode.Next = pre.Next;
                    pre.Next = newNode;
                    return;
                }
                pre = pre.Next;
            }

            // Không tìm thấy phần tử mh đã chọn, phần tử mới sẽ được thêm vào cuối danh sách 
            pre.Next = newNode;
        }
         
        // - RemoveAfter(Node pre): Xóa một phần tử sau một phần tử khác trong danh sách.
        public void RemoveAfter(Node pre)
        {
            if (pre != null && pre != _last)
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


    }
}
