using System;

namespace Exercise10
{
    class Program
    {
        /*
 10.Write program that outputs a triangle made of stars with variable size, depending on an input parameter. 
Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number.
The output is a series of lines printed on the console, forming a triangle of variable size.

    Input 2:   
    Output:    
    *   
    **
    *
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the input number to create a triangle:");
            int myNumber =Convert.ToInt32(Console.ReadLine());
            int a, b;
            
            for (a = 1; a <= myNumber; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (a = myNumber -1 ; a >= 1; a--)
            {
                for (b = a; b >= 1; b--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
