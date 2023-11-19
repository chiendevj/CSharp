using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuVien
{
    public class Admin
    {
        // Fields
        private string _user;
        private string _password;

        // Properties
        public string User()
        {
            return this._user;
        }
        public string PassWord()
        {
            return this._password;
        }

        // Constructor
        public Admin()
        {
            this._user = "unknown";
            this._password = "unknown";
        }

        public Admin(string user, string passWord)
        {
            this._user = user;
            this._password = passWord;
        }
    }
}