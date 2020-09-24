using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoDArray = CreateTwoArray();
            PrintArray(twoDArray);
            Console.WriteLine();

            // Print the sum of all elements
            Console.WriteLine($"Sum of all element = {GetSum(twoDArray)}");

            // Print the sum of the main diagonal
            Console.WriteLine($"The sum of the main diagonal = {GetSumFromMainDiagonal(twoDArray)}");
            
            Console.ReadLine();
        }

        static int[,] CreateTwoArray()
        {
            var myArray = new int[3, 3];
            Random rnd = new Random();

            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    myArray[row, col] = rnd.Next(0, 10);
                }
            }
            return myArray;
        }

        static void PrintArray(int[,] input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    Console.Write($"{input[row,col]} ");
                }

                Console.WriteLine();
            }
        }

        static int GetSum(int[,] input)
        {
            int sum = 0;
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(0); col++)
                {
                    sum += input[row, col];
                }
            }
            return sum;
        }

        static int GetSumFromMainDiagonal(int[,] input)
        {
            int sum = 0;
            for (int row = 0; row < input.GetLength(0); row++)
            {
                for (int col = 0; col < input.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sum += input[row, col];
                    }
                }
            }
            return sum;
        }
    }
}
