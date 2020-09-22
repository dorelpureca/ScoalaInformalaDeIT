using System;

namespace Exercise7
{
    class Program
    /*
     * 7.Write a program that prints on the console the numbers from 1 to N. 
     * The number N should be read from the standard input.

     */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers to be printed:");
            int endInterval = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= endInterval; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
