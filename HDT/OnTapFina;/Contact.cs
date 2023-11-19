using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OnTapFina_
{
    public class Contact
    {
        // fields
        private string _contactName;
        private string _address;
        private string _phone;
        private string _zipCode;

        // properties
        public string ContactName { get => _contactName; set => _contactName = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        

        // constructor
        public Contact() 
        {
            this._contactName = "";
            this._address = "";
            this._phone = "";
            this._zipCode = null;
        }
        public Contact(string contactName, string address, string phone)
        {
            _zipCode = Console.ReadLine();
            if (contactName.Length < 30)
            {
                _contactName = contactName;
            }
            else
            {
                _contactName = "";
            }
            _address = address;
            if (phone.Length < 11)
            {
                _phone = phone;
            }
            else
            {
                _phone = "";
            }
            
        }

        // method
        public override string ToString() 
        {
            return ($"{this._contactName,-10}{this._address,-30}{this._phone,15}");
        }

    }
}