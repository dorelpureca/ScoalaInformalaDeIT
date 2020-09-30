using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;

namespace StringsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. RemoveNthChar(1, "1234");
            //2. RemoveOddIndexChar("101010101");

            /*3&4. 
            Console.WriteLine("Enter your input that you want reversed and in lowcase letter:");
            var input = Console.ReadLine();
            Console.WriteLine("Result: "+ReverseInputLow(input));
            */


            /* 5.Console.WriteLine("Enter your input that you want reversed if is a multiple of 4:");
            var input = Console.ReadLine();
            Console.WriteLine("Result: "+ReverseInputMultiple(input));
            */

            /* 6.Console.WriteLine("Enter your input:");
            var input = Console.ReadLine();
            Console.WriteLine("Result: "+Convert2UppercaseFirst4(input));
            */

            /* 7.var input = "Ala,\nbala,\nportocala";
            Console.WriteLine(input);
            Console.WriteLine("Result:"+RemoveNewline(input));
            */
        }

        // 1.Write a method that to remove the nth index character from a nonempty string.
        public static string RemoveNthChar(int nthIndex, string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i != nthIndex)
                {
                    //Console.WriteLine(input[i]);
                    output += input[i];
                }
            }
            Console.WriteLine("The string without index " + nthIndex + " is: " + output);
            return output;
        }

        // 2.Write a method that to remove the characters which have odd index values of a given string.
        public static string RemoveOddIndexChar(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    output += input[i];
                }
            }
            Console.WriteLine("The string without odd index values is:" + output);
            return output;
        }

        // 3.Write a method that takes input from the user and displays that 
        //input back in upper and lower cases.
        public static string ReverseInputLow(string input)
        {
            string outputLower = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                if (Char.IsLetter(input[i]) == true)
                    outputLower += input[i];
            }
            outputLower = outputLower.ToLower(); //The same applies for transforming to upper case.
            Console.WriteLine("Reversed string lower case is: "+outputLower);
            return outputLower;
        }

        // 5.Write a method that reverses a string if it's length is a multiple of 4
        public static string ReverseInputMultiple(string input)
        {
            string output = "";
            if (input.Length % 4 == 0)
            {
                for (int i = input.Length-1; i >= 0; i--)
                    output += input[i];
            }
            return output;
        }

        // 6.Write method to convert a given string to all uppercase if it contains
        //at least 2 uppercase characters in the first 4 characters.
        public static string Convert2UppercaseFirst4(string input)
        {
            string output = "";
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i<4)
                {
                    if (Char.IsUpper(input[i]))
                    {
                        counter++;
                    }
                }

            }
            if (counter >= 2)
                output = input.ToUpper();
            return output;
        }

        // 7.Write a method that to remove a newline.
        public static string RemoveNewline(string input)
        {
            string output = "";
            output = input.Replace("\n", "");
            return output;
        }
    }
}
