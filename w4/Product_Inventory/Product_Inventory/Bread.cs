using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Inventory
{
    class Bread : Product
    {
        public Bread(string productName, double weight, DateTime productionDate, string producer) : base(productName, weight, productionDate, producer)
        {

        }

        public bool IsExpired()
        {
            var expireDate = ProductionDate.AddDays(4);
            var isExpired = expireDate < DateTime.Now;
            if (isExpired)
                Console.WriteLine("Your product is expired.");
            else
                Console.WriteLine("Your product is not expired.");
            return isExpired;
        }

        //public bool IsExpired
        //{
        //    get
        //    {
        //        var expireDate = ProductionDate.AddDays(2);
        //        var isExpired = expireDate < DateTime.Now;
        //        if (isExpired)
        //            Console.WriteLine("Your product is expired.");
        //        else
        //            Console.WriteLine("Your product is not expired.");
        //        return isExpired;
        //    }
        //}
    }
}
