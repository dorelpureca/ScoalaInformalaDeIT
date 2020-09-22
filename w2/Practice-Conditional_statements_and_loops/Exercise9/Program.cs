using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        /*
         9.Write a program that reads from the console a series of 5 integers and
        prints the smallest and largest of them.        
         */

        static void Main(string[] args)
        {
            int[] myNumbers = new int[5];
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine("Enter the "+(i+1)+" number:");
                myNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The biggest number is " + myNumbers.Min());
            Console.WriteLine("The smallest number is " + myNumbers.Max());
            Console.ReadLine();
        }
    }
}
