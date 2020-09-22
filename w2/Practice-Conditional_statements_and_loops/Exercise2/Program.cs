using System;
using System.Linq;

namespace Exercise2
{
    class Program         //2.Write a program that reads five numbers from the console and prints the greatest of them.
    {
        static void Main()
        {
            Console.WriteLine("<Find the greatest number>");
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number "+ (i+1));
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The greatest number is: "+numbers.Max());
            Console.ReadLine();
        }
    }
}
