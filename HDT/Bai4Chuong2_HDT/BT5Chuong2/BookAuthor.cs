using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5HDT
{
    class BookAuthor
    {
        // field
        private string _name;
        private Author[] _author;
        private double _price;
        private static int _qty = 0;

        public string Name
        {
            get
            {
                return _name;
            }

        }

        public Author[] Author
        {
            get
            {
                return _author;
            }

        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public static int Qty { get => _qty; set => _qty = value; }

        public BookAuthor(string nameBook, Author[] author, double price)
        {
            this._name = nameBook;
            this._author = author;
            this._price = price;
            _qty++;

        }
        public BookAuthor(string nameBook, Author[] author, double price, int qty)
        {
            this._name = nameBook;
            this._author = author;
            this._price = price;
            _qty++;

        }
        public string toString()
        {
            string nameBook = null;
            nameBook = $"\tTen Sach: {this._name}\n{getAuthor()}\n\tGia sach: {this._price}";
            return nameBook;
        }

        public string getAuthor()
        {
            string str = null;
            for (int i = 0; i < _author.Length; i++)
            {
                str += "\nTen tac gia: " + _author[i].Name + "\nGioi tinh: " + _author[i].Gender + "\nEmail: " + _author[i].Email;
            }
            return str;
        }

    }
}