using System;
using System.Collections.Generic;
using System.Text;

namespace SecondOOP
{
    public class Mammal
    {
        private string name;
        private int feetNo;
        //expose this through properties

        public void Eat()
        {
            Console.WriteLine("Mammal - Eat");
        }

        public void Talk()
        {
            Console.WriteLine("Mammal - Talk");
        }
    }
}
