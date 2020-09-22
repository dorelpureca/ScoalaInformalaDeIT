using System;

namespace Exercise12
{
    class Program
    {
        //12*.Write a program that by a given integer N prints the numbers from 1 to N in random order

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            Random rnd = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myListOfNumbers = new int[n];
            int randomNumber, temp;

            for (int i = 0; i < n; i++)
            {
                myListOfNumbers[i] = i;
            }

            foreach (int i in myListOfNumbers)
            {
                randomNumber = rnd.Next(0, n);
                temp = myListOfNumbers[i];
                myListOfNumbers[i] = myListOfNumbers[randomNumber];
                myListOfNumbers[randomNumber] = temp;
            }

            foreach (int i in myListOfNumbers) Console.WriteLine(myListOfNumbers[i]);

            Console.ReadLine();
        }
    }
}
