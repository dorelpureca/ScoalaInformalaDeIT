﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Inventory
{
    class Beverages: Product
    {
        public Beverages(string productName,double weight, DateTime productionDate, string producer) : base(productName, weight, productionDate,producer)
        {

        }
        public string IsExpired()
        {
            DateTime expireDate = ProductionDate.AddDays(7);
            var isExpired = expireDate > DateTime.Now;
            var resultText = "";

            if (isExpired)
                resultText += "expired!";
            else
                resultText += "not expired!";
            return resultText;
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
