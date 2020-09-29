using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate new object
            Person myPerson = new Person("Dorel", "Pureca", Person.Gender.Female);
            var name = myPerson.FirstName;
            
            myPerson.FirstName = "lalala";
            var modifiedName = myPerson.FirstName;

            var fullName = myPerson.FullName;

            var age = myPerson.Age;

            //myPerson.gender = "female";

            Console.WriteLine(age);
        }
    }
}
