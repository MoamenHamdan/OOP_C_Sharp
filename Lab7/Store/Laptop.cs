using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Laptop : Device
    {
        public string CPU { get; set; }
        public string Type { get; set; }
        public Laptop() { }
        public Laptop(string brandName, double price, string cpu, string type) : base(brandName, price)
        {
            CPU = cpu;
            Type = type;
        }
        public override string ToString()
        {
            return $"Brand: {BrandName}, Price: {price}, CPU: {CPU}, Type: {Type}";
        }

        }
}
