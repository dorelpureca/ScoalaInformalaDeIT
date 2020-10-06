using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Product_Inventory
{
    class Product
    {
        private string _productName;
        private double weight;
        private DateTime productionDate;
        private string producer;
        
        public Product(string productName, double weight, DateTime productionDate, string producer)
        {
            _productName = productName;
            this.weight = weight;
            this.productionDate = productionDate;
            this.producer = producer;
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value;
                Console.WriteLine($"This products' name is: {_productName}");
            }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value;
                Console.WriteLine($"This products' weight is: {this.weight}");
            }
        }
        public DateTime ProductionDate
        {
            get { return this.productionDate; }
            set { this.productionDate = value;
                Console.WriteLine($"This products' production date is: {this.productionDate}");
            }
        }
        public string Producer
        {
            get { return this.producer; }
            set {  this.producer = value;
                Console.WriteLine($"This products' producer is: {this.producer}");
            }
        }
    }
}
