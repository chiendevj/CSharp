using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI5HDT
{
    class Author
    {
        // filed
        private string _name;
        private string _email;
        private char _gender;

        // properties
        public string Name
        {
            get
            {
                return _name;
            }


        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (value.IndexOf("@") == -1)
                {
                    _email += "@gmail.com";
                }
                _email = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }


        }

        public Author(string name,ref char gender, string email)
        {
            this._name = name;
            if (email.IndexOf("@") == -1)
            {
                email += "@gmail.com";
                this._email = email;
            }
            else
            {
                this._email = email;
            }
            this._gender = gender;
        }
        public Author()
        {
            this._name = "";
            this._email = "";
            this._gender = '\0';
        }

        // Method
        public string toString()
        {
            return ($"Ten tac gia: {this._name}\nGioi tinh: {this._gender}\nEmail: {this._email}");
        }
    }
}