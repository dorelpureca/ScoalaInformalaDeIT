using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected string Breed { get; set; }

        public Dog(string name)
        {
            Name = name;
            Console.WriteLine("ctor from class Dog");
        }

        public void Bark()
        {
            Console.WriteLine($"My breed is {Breed}");
            Console.WriteLine($"I am {Name} and I bark!");
        }

        public virtual void Jump()
        {
            Console.WriteLine("Jump method from class Dog");
        }
    }
}
