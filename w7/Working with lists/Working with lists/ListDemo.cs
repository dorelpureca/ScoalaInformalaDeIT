using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Working_with_lists
{
    public class ListDemo
    {
        public static void RunDemo()
        {
            var cities = new List<string>() { "Cluj", "Timisoara", "Iasi" };
            //List<string> cities = new List<string>();
            Print(cities);

            cities.Add("Sibiu");
            cities.Add("Timisoara");
            Print(cities);


            cities.Remove("Timisoara");
            Print(cities);

            cities.RemoveAt(1);
            Print(cities);

        }

        private static void Print(List<string> list)
        {
            foreach (var city in list)
            {
                Console.Write(city + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Current number of elements {list.Count}");
            Console.WriteLine();
        }
    }
}
