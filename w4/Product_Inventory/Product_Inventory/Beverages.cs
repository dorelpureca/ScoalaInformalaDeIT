using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Inventory
{
    class Beverages: Product
    {
        public Beverages(string productName,double weight, DateTime productionDate, string producer) : base(productName, weight, productionDate,producer)
        {

        }
        public bool IsExpired()
        {
            DateTime expireDate = ProductionDate.AddYears(3);
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
        //        DateTime expireDate = ProductionDate.AddYears(3);
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
