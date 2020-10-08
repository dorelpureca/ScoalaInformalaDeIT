using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Beagle : Dog, IRun
    {
        public Beagle(string name, string trick) : base(name)
        {
            Console.WriteLine("ctor from class Beagle");    
        }

        public void Hunt()
        {
            Console.WriteLine($"{Breed}");
            Console.WriteLine("I hunt");
        }

        public new void Bark()
        {
            var age = base.Age;
            var age2 = Age;

            base.Bark();//calling parent class's method

            Console.WriteLine($"I am a beagle and I bark");
        }

        public void Run()
        {
            Console.WriteLine("I run, from Run method");
        }

        public void Run(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"I run {i} from Run method");
            }

        }

        public override void Jump()
        {
            Console.WriteLine("Method Jump from class Beagle");
        }
    }
}
