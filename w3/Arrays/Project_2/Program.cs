using System;
using System.Diagnostics;
using System.IO;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print array of random numbers
            int[] numbers = CreateArray();
            int[] otherNumbers = CreateArray();
            //PrintArray(numbers);
            //Console.WriteLine();

            //// Max from array
            //Console.WriteLine($"\nMax number is: {GetMaxFromArray(numbers)}");

            //// Number of occurences of an element
            //Console.WriteLine($"\n{numbers[0]} appears {GetOccurences(numbers)}");

            //// Sum of even numbers
            //Console.WriteLine($"\nTotal sum of even numbers is {GetSumOfEvenNumbers(numbers)}");

            //// Reverse an array
            //Console.WriteLine("\nReversed array: ");
            //var arrayToPrint = ReverseArray(numbers);
            //PrintArray(arrayToPrint);

            //// Sort Ascending an array
            //Console.WriteLine("\nAscending array: ");
            //var sortedAsc = BubbleSort(numbers);
            //PrintArray(sortedAsc);
            //Console.WriteLine();
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort(numbers);
            sw.Stop();
            Console.WriteLine($"\nBubble sort took: {sw.ElapsedMilliseconds} ms");
            sw.Reset();

            sw.Start();
            Array.Sort(otherNumbers);
            sw.Stop();
            Console.WriteLine($"\nArray.sort took: {sw.ElapsedMilliseconds} ms");
            sw.Reset();

            Console.ReadLine();

        }

        static int[] CreateArray()
        {
            int[] numbers = new int[10000];
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

        static int[] ReverseArray(int[] input)
        {
            int[] output = new int[input.Length];
            int outputIndex = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output[outputIndex] = input[i];
                outputIndex++;
            }
            return output;
        }

        static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i]>input[j])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }


    }
}
