using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTapFina_
{
    public class Person
    {
        // fields
        private string name;
        private string citizenID;
        private DateTime birthDate;
        private Contact postalDetail;

        // properties
        public string Name { get => name; }
        public string CitizenID { get => citizenID;}
        public DateTime BirthDate { get => birthDate; }
        public Contact PostalDetail { get => postalDetail; set => postalDetail = value; }

        // Constructor
        public Person(string name, string citizenID, DateTime birthDate, Contact postalDetail)
        {

            this.name = name;
            this.citizenID = citizenID;
            this.birthDate = birthDate;
            this.postalDetail = postalDetail;
        }

        
    }
}