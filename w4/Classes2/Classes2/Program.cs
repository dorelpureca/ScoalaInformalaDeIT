using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rila = new Rabbit(   Rabbit.EyesColor.Black,
                                        Rabbit.FurColor.Brown,
                                        Rabbit.Gender.Female,
                                        new DateTime(2010,01,01), 
                                        new Owner("Mihai", "Viteazu", 12331, "Unirii"));
            Print(rila);

            //Console.WriteLine($"Rabbit's age is: {rila.Age} years");             
        }
        static void Print(Rabbit rabbit)
        {
            Console.WriteLine($"Rabbit's eyes color is: {rabbit.Eye}");
            Console.WriteLine($"Rabbit's fur color is: {rabbit.Fur}");
            Console.WriteLine($"Rabbit's gender is: {rabbit.Sex}");
            Console.WriteLine($"Owner's first name: {rabbit.OwnerDetails.FirstName}");
            Console.WriteLine($"Owner's last name: {rabbit.OwnerDetails.LastName}");
            Console.WriteLine($"Owner's postal code: {rabbit.OwnerDetails.PostalCode}");
            Console.WriteLine($"Owner's address: {rabbit.OwnerDetails.Address}");
        }
    }
}