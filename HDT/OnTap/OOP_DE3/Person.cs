using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace OOP_DE3
{
    public class Person
    {
        // field
        private string _name;
        private string _citizenID;
        private DateTime _birthDate;
        private PostalDetail _contact;

        // properties
        public string Name { get => _name; set => _name = value; }
        public string CitizenID { get => _citizenID; set => _citizenID = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public PostalDetail Contact { get => _contact; set => _contact = value; }

        // constructor
        public Person()
        {
            _name = "";
            _citizenID = "";
            _birthDate = DateTime.Now;
            _contact = new PostalDetail();
        }

        public Person(Person ps)
        {
            this._name = ps.Name;
            this._citizenID = ps.CitizenID;
            this._birthDate = ps.BirthDate;
            this._contact = ps.Contact;
        }
        public Person(string name, string citizenID, DateTime birthDate, PostalDetail contact)
        {
            _name = name;
            _citizenID = citizenID;
            _birthDate = birthDate;
            _contact = contact;
        }

        public Person(string name, string citizenID)
        {
            this._name = name;
            this._citizenID = citizenID;
        }
        // method
        public override string ToString() 
        {
            return ($"{this._name}#{this._citizenID}#{this._birthDate.ToString("dd/MM/yyyy")}#{this._contact.ToString()}");
        }

    }
}