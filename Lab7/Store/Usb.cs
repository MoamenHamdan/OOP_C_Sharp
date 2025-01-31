using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Usb : Device
    {
        
        public int Capacity { get; set; }
        public Usb(string brandName, double price, int capacity) : base(brandName, price)
        {
           
            Capacity = capacity;
        }
        public Usb() { }
        public void toString()
        {
            Console.WriteLine($"Brand: {BrandName}, Price: {price}, Capacity: {Capacity}");
        }
    }
}
