using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Classes
{
    //class Person   =  Default access modifier for classes is internal
    //internal class = Person - is the same thing!
    public class Person
    {
        // class fields
        private string firstName;
        private string lastName;
        private readonly DateTime birthDate;
        public const decimal temperature=25.23M;
        public readonly Gender gender;
        
        public string FirstName
        {
            get { return firstName; }   //if you use only get -> read only
            set { firstName = value; }  //if you use only set -> write only
        }                               //if you use both     -> read-write
        
        public Person(string first, string last)  //Access modifier
        {
            firstName = first;
            lastName = last;
            birthDate = DateTime.Now;
        }
        
        public Person(string first, string last, Gender gender)  //Access modifier
        {
            firstName = first;
            lastName = last;
            birthDate = new DateTime(1989,03,06);
            this.gender = gender;
        }

        public int Age 
        { 
            get
            {
                return DateTime.Now.Year - birthDate.Year;
            }
        }
        
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        
        public enum Gender
        {
            Male,
            Female,
            NA
        }
    }
}
