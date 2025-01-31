using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many device do you want ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter Information of device " + (i + 1));
                Device device = new Device();
                Console.WriteLine("Brand : ");
                string b = Console.ReadLine();
                device.BrandName = b;
                Console.WriteLine("Price ");
                int p = Convert.ToInt32(Console.ReadLine());
                device.price = p;
                Console.WriteLine("Is it Laptop or Usb ");
                string type = Console.ReadLine();
                if (type.Equals("Laptop"))
                {
                    Laptop laptop = new Laptop();
                    Console.WriteLine("CPU : ");
                    string cpu = Console.ReadLine();
                    laptop.CPU = cpu;
                    Console.WriteLine("Type : ");
                    string t = Console.ReadLine();
                    laptop.Type = t;

                }
                else if (type.Equals("Usb"))
                {
                    Usb usb = new Usb();
                    Console.WriteLine("Capacity : ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    usb.Capacity = c;

                }
                else
                {
                    Console.WriteLine("Invalid type");
                }

            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Information of device " + (i + 1));
                Device device = new Device();
                Console.WriteLine("Brand : " + device.BrandName);
                Console.WriteLine("Price : " + device.price);
                Console.WriteLine("Is it Laptop or Usb ");
                string type = Console.ReadLine();
                if (type.Equals("Laptop"))
                {
                    Laptop laptop = new Laptop();
                    Console.WriteLine("CPU : " + laptop.CPU);
                    Console.WriteLine("Type : " + laptop.Type);
                }
                else if (type.Equals("Usb"))
                {
                    Usb usb = new Usb();
                    Console.WriteLine("Capacity : " + usb.Capacity);
                }
                else
                {
                    Console.WriteLine("Invalid type");
                }
            }




        }
    }
}
