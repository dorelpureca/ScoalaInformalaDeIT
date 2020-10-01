using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    class Owner
    {
        private string firstName;
        private string lastName;
        private int postalCode;
        private string address;
        public Owner(string firstName, string lastName, int postalCode, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.postalCode = postalCode;
            this.address = address;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { lastName = value; }
        }
        public int PostalCode
        {
            get { return this.postalCode; }
            set { postalCode = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { address = value; }
        }
    }
}
