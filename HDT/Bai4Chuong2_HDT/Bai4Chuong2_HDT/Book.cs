using Author;

namespace Bai4Chuong2_HDT
{
    internal class Book
    {
        // fielD
        private string _nameBook;
        private Author1 _author;
        private double _price;
        private int _qty = 0;

        // properties
        public string NameBook { get => _nameBook; set => _nameBook = value; }
        public double Price { get => _price; set => _price = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public Author1 Author { get => _author; set => _author = value; }

        public Book(string name, Author1 author, double price)
        {
            this._nameBook = name;
            this._author = author;
            this._price = price;
        }

        public Book(string name, Author1 author, double price, int qty)
        {
            this._nameBook = name;
            this._author = author;
            this._price = price;
            this._qty = qty;
        }
        // Method

        public string toString()
        {
            return ($"\tName Book: {this._nameBook}\n\tTac Gia: {this.Author.toString()}\n\tprice = {this._price}\n\tqty = {this._qty}");
        }



    }
}
