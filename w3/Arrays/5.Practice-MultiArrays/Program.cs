using System;
using System.Runtime.InteropServices;

namespace _5.Practice_MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my2dArray = CreateTwoArray();
            Print2dArray(my2dArray);
            int sum = SumOfMainDiagonal(my2dArray);
            Console.WriteLine("The sum of main diagonal:"+sum);

        }

        static int[,] CreateTwoArray()
        {
            int[,] myTwoArray = new int[5, 5];
            Random rnd = new Random();
            for (int row = 0; row < myTwoArray.GetLength(0); row++)
            {
                for (int col = 0; col < myTwoArray.GetLength(1); col++)
                {
                    myTwoArray[row, col] = rnd.Next(0, 10);
                }
            }
            return myTwoArray;
        }

        static void Print2dArray(int[,] inputArray)
        {
            for (int row = 0; row < inputArray.GetLength(0); row++)
            {
                for (int col = 0; col < inputArray.GetLength(1); col++)
                {
                    if (row==col)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write($" {inputArray[row, col]} ");
                        Console.ResetColor();
                    }
                    else
                    Console.Write($"{inputArray[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        static int SumOfMainDiagonal(int[,] inputArray)
        {
            int sum = 0;
            for (int row = 0; row < inputArray.GetLength(0); row++)
            {
                for (int col = 0; col < inputArray.GetLength(1); col++)
                {
                    if (col==row)
                    {
                        sum += inputArray[row, col];
                    }
                }
            }
            return sum;
        }
    }
}
