using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[3];

            userNumbers[0] = 3;

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine("Input number "+(i+1)+":");
                //myFirstArray[i] = Convert.ToInt32(Console.ReadLine());
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("You provided the following numbers");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.Write($"{userNumbers[i]}, ");

            }

            Console.WriteLine();
            foreach (var number in userNumbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine();
            int counter = 0;
            while (counter < userNumbers.Length)
            {
                Console.Write($"{userNumbers[counter]}, ");
                counter++;
            }

            Console.WriteLine();


        }
    }
}
