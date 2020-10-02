using System;

namespace Product_Inventory
{
    class Program
    {
        static void Main()
        {
            var myYogurt = new Dairy("Danone", 500, new DateTime(2020-10-01), "Albalact");
            //Console.WriteLine(myYogurt.IsExpired());
            Console.WriteLine(myYogurt.IsExpired);

        }
    }
}
