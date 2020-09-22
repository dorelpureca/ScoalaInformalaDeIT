using System;

namespace Exercise3
{
    class Program       //3.Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
                        // P = 2*pi*r;
                        // A = pi*r^2;
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of a circle:");
            double varRadius = Convert.ToDouble(Console.ReadLine());
            double varPi = Math.PI;

            Console.WriteLine("The Perimter of the circle is: "+ (2*varPi*varRadius));
            Console.WriteLine("The Area of the circle is: " + (varPi * (varRadius * varRadius)));
            Console.WriteLine("The Area of the circle is: " + (varPi * Math.Pow(varRadius,2)));

            Console.ReadLine();

        }
    }
}
