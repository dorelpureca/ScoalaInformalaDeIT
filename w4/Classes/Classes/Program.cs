using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate new object
            Person myPerson = new Person("Dorel", "Pureca", Person.Gender.Male);
            var name = myPerson.FirstName;
            Console.WriteLine(name);
            
            myPerson.FirstName = "lalala";
            var modifiedName = myPerson.FirstName;
            Console.WriteLine(modifiedName);

            var fullName = myPerson.FullName;
            Console.WriteLine(fullName);

            var age = myPerson.Age;
            Console.WriteLine(age);

            //myPerson.gender = "female";
        }
    }
}
