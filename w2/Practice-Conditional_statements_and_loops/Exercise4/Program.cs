using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program           
        /*4.Write a program that reads from the console two integer numbers (int) and 
        prints how many numbers between them exist that are divisible with 5. such that the
        remainder of their division by 5 is 0.
        
        Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25. */

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number of the interval:");
            int startInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number of the interval:");
            int endInt = Convert.ToInt32(Console.ReadLine());
            List<int> dividingNumbers = new List<int>();
            int varCounter=0;

            for (int i = startInt; i <= endInt; i++)
            {
                if (i%5==0)
                {
                    varCounter = varCounter + 1;
                    dividingNumbers.Add(i);
                }
            }
            Console.WriteLine("There are "+varCounter+" numbers divided by 5.\nThe numbers are:");
            dividingNumbers.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
