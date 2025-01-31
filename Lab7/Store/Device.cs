using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Device
    {
        public string BrandName { get; set; }
        public double price { get; set; }

        public Device(string brandName, double price)
        {
            BrandName = brandName;
            this.price = price;
        }
        public Device() { }

        public void toString()
        {
            Console.WriteLine($"Brand: {BrandName}, Price: {price}");
        }
    }
}
