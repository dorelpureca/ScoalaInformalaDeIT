using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Practise_Classes
{
    class Owner
    {
        private string firstName;
        private string lastName;
        private string address;
        private int postalCode;

        public Owner(string firstName,string lastName, string address, int postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.postalCode = postalCode;
        }

        public string OwnerFirstName
        {
            get { return firstName; }
            set { firstName = value; } 
        }
        public string OwnerLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string OwnerAddress
        {
            get { return address; }
            set { address = value; }
        }
        public int OwnerPostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

    }

    
}
