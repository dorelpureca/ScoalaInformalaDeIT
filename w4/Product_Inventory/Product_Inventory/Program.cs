using System;
using System.Runtime.Serialization;
using System.Threading;

namespace Product_Inventory
{
    class Program
    {
        static void Main()
        {
            var myYogurt = new Dairy("Danone", 500, new DateTime(2010,01,01), "Albalact");
            Console.WriteLine($"Your {myYogurt.ProductName} is {myYogurt.IsExpired()}");
            

            var myBeverage = new Beverages("Pepsi", 500, new DateTime(2018,01,01), "American Cola");
            Console.WriteLine($"Your {myBeverage.ProductName} is {myBeverage.IsExpired()}");
            //Console.WriteLine(myBeverage.IsExpire);

            var myFruit = new Fruits("Apple", 100, new DateTime(2020, 10, 06), "Agricultura vie");
            Console.WriteLine($"Your {myFruit.ProductName} is {myFruit.IsExpired()}");
            //Console.WriteLine(myFruit.IsExpire);

            var myBread = new Bread("French baguette", 800, new DateTime(2020, 10, 03), "TransAgape");
            Console.WriteLine($"Your {myBread.ProductName} is {myBread.IsExpired()}");
            //Console.WriteLine(myBread.IsExpire);

            Console.ReadLine();
        }
    }
}
