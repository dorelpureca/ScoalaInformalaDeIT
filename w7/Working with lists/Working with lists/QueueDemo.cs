using System;
using System.Collections.Generic;
using System.Text;

namespace Working_with_lists
{
    public class QueueDemo
    {
        public static void RunDemo()
        {
            var cities = new Queue<string>();

            cities.Enqueue("Sibu");
            cities.Enqueue("Iasi");
            Print(cities);

            cities.Enqueue("Bucuresti");
            cities.Enqueue("Timisoara");
            Print(cities);

            var city = cities.Dequeue();
            Console.WriteLine($"Deqeueud city: {city}");
            Console.WriteLine();
            Print(cities);

            Console.WriteLine($"Queue contains \"Timisoara\": {cities.Contains("Timisoara")}");
            Console.WriteLine($"Queue contains \"Oradea\": {cities.Contains("Oradea")}");

        }

        private static void Print(Queue<string> cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine($"Current first element is: {cities.Peek()}");
            Console.WriteLine($"Current number of elements is: {cities.Count}");
            Console.WriteLine();
        }

    }
}
