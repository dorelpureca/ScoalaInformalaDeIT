using Microsoft.VisualBasic;
using System;

namespace Exercise8
{
    class Program
    /*
     * 8.Write a program that prints on the console the numbers from 1 to N, 
     * which are not divisible by 3 and 7 simultaneously. 
     * The number N should be read from the standard input.

     */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers to be printed, that are not divisible by 3 and 7:");
            int endInterval = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= endInterval; i++)
            {
                if (i%3!=0 && i%7!=0) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
