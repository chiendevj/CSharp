using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Author1
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
                if (Email.IndexOf("@") == -1)
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

        public Author1(string name,ref char gender, string email)
        {
            this._name = name;
            this._gender = gender;

            if (email.IndexOf("@") == -1)
            {
                email += "@gmail.com";
                this._email = email;
            }
            else
            {
                this._email = email;
            }
        }
        public Author1()
        {
            this._name = "";
            this._email = "";
            this._gender = '\0';
        }

        // Method
        public string toString()
        {
            return ($"{this._name}({this._gender}) at {this._email}!!");
        }

    }
}