using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_DE3
{
    public class PostalDetail
    {
        // fields
        private string _phone;
        private string _address;
        private string _city;
        private string _zipCode;

        // properties
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string ZipCode { get => _zipCode; set => _zipCode = value; }

        // constructor

        public PostalDetail()
        {
            _phone = "";
            _address = "";
            _city = "";
            _zipCode = "";
        }

        public PostalDetail(string phone, string address, string city, string zipCode)
        {
            _phone = phone;
            _address = address;
            _city = city;
            _zipCode = zipCode;
        }

        public PostalDetail(string phone, string address)
        {
            _phone = phone;
            _address = address;
           
        }

        // method
        public override string ToString()
        {
            return ($"{this._phone}#{this._address}");
        }

    }
}   