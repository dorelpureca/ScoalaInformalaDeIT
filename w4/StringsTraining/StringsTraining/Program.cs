using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
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

            /* Max chars per row
            var input = "1234567890qwertyuiopasdfghjkl;";
            var rowlength = 4;
            Console.WriteLine(MaxCharsPerRow(input,rowlength));
            */

            //var input = "aa@bb.cc";
            //int index;
            //index=input.IndexOf("@");
            //string domain = input.Substring(index,input.Length-index);
            //Console.WriteLine("********"+domain);
            //Console.WriteLine(ObfucateEmail(input));

            /*Write a method to get a string made of the first 2 and
             the last 2 chars from a given a string. If the string length 
             is less than 2, return instead of the empty string.
            var input = "recececede";
            Console.WriteLine(ReString(input));
            */

            //var input = "restart";
            //Console.WriteLine(ReplaceChar1(input));

            //var input = "abc xyz";
            //Console.WriteLine(ReplaceChar2(input));

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
            string output;
            output = input.Replace("\n", "");
            return output;
        }

        // 8.Write a method to display formatted text (width=50) as output. For example: If I 
        // have a text that's 134 characters long, the formatted string should have maximum of 
        // 50 characters per line. In this case we will have 3 lines of text.
        public static string MaxCharsPerRow(string input, int rowlength)
        {
            string output = "";
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (index < rowlength)
                {
                    output += input[i];
                    index++;
                }
                else if (index == rowlength)
                {
                    output += "\n";
                    index = 0;
                }
            }
                return output;
        }
        public static string ObfucateEmail(string input)
        {
            string userName = "";
            string emailDomain = "";
            int index;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '@')
                {
                    index = i;
                    for (int j = index; j < input.Length; j++)
                        emailDomain += input[j];
                    break;
                }
                if (input[i] != '@')
                    userName += "*";
            }

            string output = userName + emailDomain;
            return output;
        }

        public static string ReString(string input)
        {
            string output = "";
            string startStr = "";
            string endStr = "";
            if (input.Length > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    startStr += input[i];
                }
                for (int i = input.Length - 2; i < input.Length; i++)
                {
                    endStr += input[i];
                }
                output = startStr + endStr;

            }
            else
            output = "";
            return output;
        }
        //Write a method to get a string from a given string where all
        //occurrences of its first char have been changed to '$', except 
        //the first char itself.
        public static string ReplaceChar1(string input)
        {
            string output = "";
            string firstChar = "";
            firstChar += input[0];
            output += firstChar;
            for (int i = 1; i < input.Length; i++)
            {
                if (Convert.ToString(input[i]) == firstChar)
                    output += "#";
                else
                    output += input[i];
            }
            return output;
        }
        //Write a method to get a single string from two given strings, 
        //separated by a space and swap the first two characters of each
        //string.
        //  Input: 'abc', 'xyz' 
        // Output: 'xyc abz'
        public static string ReplaceChar2(string input)
        {
            string output = "";
            string string1 = "";
            string string2 = "";
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Convert.ToString(input[i]) == " ")
                    index = i;
            }

            for (int i = 0; i < index; i++)
            {
                string1 += input[i];
            }
            for (int i = index + 1; i < input.Length; i++)
            {
                string2 += input[i];
            }
            output = $"String1: {string1}, String2: {string2}";

            int counter = 0;
            string string1_1 = "";
            for (int i = 0; i < string1.Length; i++)
            {
                if (counter < 2)
                {
                    string1_1 += string1[i];
                    counter++;
                }
            }
                string1_1 += string2.Substring(string2.Length-1);
            
            counter = 0;
            string string2_1 = "";
            for (int i = 0; i < string2.Length; i++)
            {
                if (counter < 2)
                {
                    string2_1 += string2[i];
                    counter++;
                }
            }
                string2_1 += string1.Substring(string1.Length - 1);

            output = $"String1: {string1_1}, String2: {string2_1}";

            return output;
        }
        /*Write a method to find the first appearance of the substring 
          'not' and 'poor' from a given string, if 'not' follows the 
          'poor', replace the whole 'not'...'poor' substring with 'good'.
          Return the resulting string.
            Input: 'The lyrics is not that poor!'
            Output : 'The lyrics is poor!'
            Input  : 'The lyrics is good!'
            Output : 'The lyrics is poor!'*/
        public static string ReplaceChar3(string input)
        {
            string[] myArray = new string[input.Length];
            myArray = input.Split(' ');
            int i = 0;
            foreach (string word in myArray)
            {
                i++;
                if (word == "not")
                {
                    Console.WriteLine($"Word 'not' found at position {i}");
                }
                i++;
                if (word == "poor")
                {
                    Console.WriteLine($"Word 'poor' found at position {i}");
                }
            }

        }

    }
}
