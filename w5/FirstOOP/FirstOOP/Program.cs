using System;

namespace FirstOOP
{
    class Program
    {
        static void Main()
        {

            var myDog = new Dog("Grivei");
            myDog.Bark();
            

            var myBeagle = new Beagle("Max", "fetch");
            myBeagle.Hunt();
            myBeagle.Bark();
            myBeagle.Name = "Beagle name";
            myBeagle.Jump();



            IRun runner = new Human();
            runner = myBeagle;
            runner.Run();


            Console.ReadLine();
        }
    }
}
