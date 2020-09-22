using System;
using System.Globalization;
using System.Linq;

namespace Exercise6
{
    class Program
    /*
     6.Write a program that reads five integer numbers and prints their sum.
     If an invalid number is entered the program should prompt the user to enter another number(only once)

     */
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[5];

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1)+": ");
                //myNumbers[i] = Convert.ToInt32(Console.ReadLine());
                string inputNumber = Console.ReadLine();
                int parsedValue;

                if (int.TryParse(inputNumber, out parsedValue) == false)
                {
                    do
                    {
                        Console.WriteLine("Try again!");
                        inputNumber = Console.ReadLine();
                    } while (int.TryParse(inputNumber, out parsedValue) == false);
                }

                if (int.TryParse(inputNumber, out parsedValue) == true)
                {
                    myNumbers[i] = parsedValue;
                }
            }
            Console.WriteLine("The total sum of my numbers is: "+myNumbers.Sum());
            Console.ReadLine();
        }
    }
}
