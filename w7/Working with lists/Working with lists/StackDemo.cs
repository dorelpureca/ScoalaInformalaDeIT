using System;
using System.Collections.Generic;
using System.Text;

namespace Working_with_lists
{
    public class StackDemo
    {
       public static void RunDemo()
        {
            var cities = new Stack<string>();
            cities.Push("Cluj");
            cities.Push("Timisoara");
            cities.Push("Sibiu");
            cities.Push("Bucuresti");
            Print(cities);

            Console.WriteLine(cities.Pop());
            //cities.Pop();
            Print(cities);

            Console.WriteLine(cities.Contains("Sibiu"));

            var citiesArray = cities.ToArray();
            Print(cities);

        }
        private static void Print(Stack<string> cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine($"Top element in the stack: {cities.Peek()}");
            Console.WriteLine($"Current number of elements: {cities.Count}");

            Console.WriteLine();
        }
    }
}
