/*
Ho va ten : Nguyen Phuong Tan
MSSV : 22211TT1242
Ngay code : 18/6/2023




*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public class Contact
    {
        private string contactName;
        private string address;
        private string phone;
        private string zipCode;

        public string ContactName{
            get{
                return this.contactName;
            }

            set{
                if (value.Length < 30)
                {
                    this.contactName = value;
                }
                else{
                    throw new Exception("Length not >= 30");
                }
                
            }
        }

        public string Address{
            get{
                return this.address;
            }

            set{
                this.address = value;
            }
        }

        public string Phone{
            get{
                return this.phone;
            }

            set{
                if (value.Length < 11)
                {
                    this.phone = value;
                }
                else{
                    throw new Exception("Length not >= 11");
                }
            }
        }

        public string ZipCode{
            get{
                return this.zipCode;
            }

            set{
                if (value.Length == 5)
                {
                    this.zipCode = value;
                }
                else{
                    throw new Exception("length not !=5");
                }
                
            }
        }
        
        public Contact()
        {
            this.contactName = "u";
            this.address = "u";
            this.phone = "u";
            this.zipCode = "u";
        }

        //constructer
        public Contact(string name,string address, string phone){
            {
                if (name.Length < 30)
                {
                    this.contactName = name;
                }
                else{
                    throw new Exception("Length not >= 30");
                }
                this.address = address;

                 if (phone.Length < 11)
                {
                    this.phone = phone;
                }
                else{
                    throw new Exception("Length not >= 11");
                }
            }

        }

        public override string ToString()
        {
            return $"{this.ContactName}#{this.address}#{this.phone}#{this.zipCode}";
        }
        
    }
}