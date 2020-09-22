using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program       
        /*
        5.Write a program that reads two numbers from the console and prints
        the greater of them. Solve the problem without using conditional statements
        and with conditional statements.            NOT WORKING. TO BE DONE.
        */
    {
        static void Main(string[] args)
        {
            List<int> myNumbers= new List<int>();
            Console.WriteLine("Enter the numbers, separated by comma:");
            myNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(myNumbers.Count);
            Console.ReadLine();
        }
    }
}
