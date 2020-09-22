using System;

namespace Exercise1
{
    class Program               //1.Write a program that reads from the console three numbers of type int and prints their sum.

    {
        static void Main()
        {
            Console.WriteLine("<Calculate a sum of 3 numbers>");
            Console.WriteLine("Please enter the first number:");
            string firstNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out int a) == false)
            {

                do
                {
                    Console.WriteLine("This is not a number. Please type the first number:");
                    firstNumber = Console.ReadLine();
                }
                while (int.TryParse(firstNumber, out a) == false);
            }
                    
            Console.WriteLine("Please enter the second number:");
            string secondNumber = Console.ReadLine();

            if (int.TryParse(secondNumber, out int b) == false)
            {

                do
                {
                    Console.WriteLine("This is not a number. Please type the second number:");
                    secondNumber = Console.ReadLine();
                }
                while (int.TryParse(secondNumber, out b) == false);
            }

            Console.WriteLine("Please enter the third number:");
            string thirdNumber = Console.ReadLine();

            if (int.TryParse(thirdNumber, out int c) == false)
            {

                do
                {
                    Console.WriteLine("This is not a number. Please type the third number:");
                    thirdNumber = Console.ReadLine();
                }
                while (int.TryParse(thirdNumber, out c) == false);
            }

            Console.WriteLine("The sum is: "+Sum(a,b,c));
            Console.ReadLine();
        }

        static int Sum(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
