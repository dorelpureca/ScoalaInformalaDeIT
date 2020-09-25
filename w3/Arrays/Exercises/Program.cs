using System;
using System.Reflection.Metadata.Ecma335;

namespace Exercises
{
    class Program                           /* Exercises with Arrays
                                            1.Generate a random array
                                            2.Reverse array
                                            3.Max of an array
                                            4.Min of an array
                                            5.Total sum of even numbers from array
                                            6.Number of occurences of a number from an array
                                            7.Sort ascending array
                                            */

    {
        static void Main(string[] args)
        {
            int[] myArray = GenerateRandomArray();
            Console.Write("\nPrint array         : "); 
            PrintArray(myArray);

            Console.Write("\nPrint reversed array: ");
            PrintArray(ReverseArray(myArray));

            int max = MaxOfArray(myArray);
            Console.WriteLine($"\nPrint max of array  : {max}");

            int min = MinOfArray(myArray);
            Console.WriteLine($"Print min of array  : {min}");

            int sum = SumOfEvenNumbers(myArray);
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sum of even numbers : {sum}");
            Console.ResetColor();

            int counter = OccurencesOfNumber(myArray);
            Console.WriteLine($"Occurences of {myArray[0]} is {counter} times");

            Console.WriteLine("Sorting ascending:");
            PrintArray(SortAscendingArray(myArray));



        }

        static int[] GenerateRandomArray()
        {
            int[] myArray = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0, 11);
            }
            return myArray;
        }

        static void PrintArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]}, ");
            }
        }

        static int[] ReverseArray(int[] inputArray)
        {
            int[] outputArray = new int[inputArray.Length];
            int outputIndex = 0;
            for (int i = inputArray.Length-1; i >= 0; i--)
            {
                outputArray[outputIndex] = inputArray[i];
                outputIndex++;
            }
            return outputArray;
        }
        
        static int MaxOfArray(int[] inputArray)
        {
            int max = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (max<inputArray[i])
                {
                    max = inputArray[i];
                }
            }
            return max;
        }

        static int MinOfArray(int[] inputArray)
        {
            int min = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (min>inputArray[i])
                {
                    min = inputArray[i];
                }
            }
            return min;
        }

        static int SumOfEvenNumbers(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] %2 == 0)
                {
                    sum += inputArray[i];
                }
            }
            return sum;
        }

        static int OccurencesOfNumber(int[] inputArray)
        {
            int counter = 0;
            int reference = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i]==reference)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int[] SortAscendingArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i]<inputArray[j])
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;

                    }
                }
            }
            return inputArray;
        }
    }
}
