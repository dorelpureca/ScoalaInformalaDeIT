using System;
using System.IO;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print array of random numbers
            int[] numbers = CreateArray();
            PrintArray(numbers);
            Console.WriteLine();

            // Max from array
            Console.WriteLine($"Max number is: {GetMaxFromArray(numbers)}");
            Console.WriteLine();

            // Number of occurences of an element
            Console.WriteLine($"{numbers[0]} appears {GetOccurences(numbers)}");
            Console.WriteLine();

            // Sun of even numbers
            Console.WriteLine($"Total sum of even numbers is {GetSumOfEvenNumbers(numbers)}");
            Console.WriteLine();

            Console.ReadLine();

        }

        static int[] CreateArray()
        {
            int[] numbers = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 40);
            }

            return numbers;
        }

        static void PrintArray(int[] arrayToPrint)
        {
            foreach (var number in arrayToPrint)
            {
                Console.Write($"{number}, ");
            }
        }

        static int GetMaxFromArray(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }

        static int GetOccurences(int[] numbers)
        {
            int counter = 0;
            int reference = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==reference)
                {
                    counter++;
                }
            }

            return counter;
        }

        static int GetSumOfEvenNumbers(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    sum = sum + number;
            }
            return sum;
        }

    }
}
