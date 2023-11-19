using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public class Person
    {
        private string name;
        private string citizenID;
        private DateTime birthDay;
        private Contact postalDetail;

        public string Name{
            get {
                return this.name;
            }
        }

        public string CitizenID{
            get {
                return this.citizenID;
            }
        }

        public DateTime BirthDay{
            get {
                return this.birthDay;
            }
        }

        public Contact PostalDetail{
            get {
                return this.postalDetail;
            }

            set{
                this.postalDetail = value;
            }
        }

        public Person()
        {
            this.name = "u";
            this.citizenID = "u";
            this.birthDay = new DateTime();
            this.postalDetail = new Contact();
        }

        //constructer
        public Person(string name,string citizenID,Contact contact)
        {
            //Cau hoi 2
            if (name.Length >= 2 && name.Length <= 30)
            {
               this.name = name;
            }
            else{
                throw new Exception("Khong hop le");
            }

            if (citizenID.Length < 11)
            {
                foreach(char kt in citizenID.ToCharArray())
                {
                    if (!(kt >= '0' && kt <= '9'))
                    {
                        throw new Exception("CitizenID khong hop le");
                    }
                }
                this.citizenID = citizenID;
            }
            else{
                throw new Exception("CitizenID khong hop le");
            }

            this.postalDetail = contact;

        }

        public override string ToString()
        {
            return $"{this.name}#{this.citizenID}#{this.birthDay}#{this.postalDetail.ToString()}";
        }
    }
}