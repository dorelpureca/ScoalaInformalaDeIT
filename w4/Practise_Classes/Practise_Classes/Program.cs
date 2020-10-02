using System;
using System.Security.Cryptography.X509Certificates;

namespace Practise_Classes
{
    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog(
                "Max",
                Dog.EyesColor.Blue,
                Dog.FurColor.White,
                Dog.Gender.Male,
                new DateTime(2010, 01, 01),
                new Owner("Dorel","Pureca","Sibiu",550388)
                );

            Print(myDog);
        }
        static void Print(Dog dogInfo)
        {
            Console.WriteLine($"My dog's name is {dogInfo.DogsName}");
            Console.WriteLine($"My dog's eyes color is {dogInfo.Eyes}");
            Console.WriteLine($"My dog's fur color is {dogInfo.Fur}");
            Console.WriteLine($"My dog's gender is {dogInfo.Sex}");
            Console.WriteLine($"My dog's dob is {dogInfo.DogsDOB}");
            Console.WriteLine($"Owner's first name is {dogInfo.OwnerDetails.OwnerFirstName}");
            Console.WriteLine($"Owner's last name is {dogInfo.OwnerDetails.OwnerLastName}");
            Console.WriteLine($"Owner's address name is {dogInfo.OwnerDetails.OwnerAddress}");
            Console.WriteLine($"Owner's postal code name is {dogInfo.OwnerDetails.OwnerPostalCode}");
        }
        

        
    }
}
