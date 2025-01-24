using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Trapizoid t1 = new Trapizoid(10,14,3.5);
            Trapizoid t2 = new Trapizoid(3.5, 2.8,11.4);
            Console.WriteLine("Area of Trapizoid 1 is : " + t1.Area() + " A = "+t1.a + " B = " +t1.b + " H = " + t1.h);
            Console.WriteLine("Area of Trapizoid 2 is : " + t2.Area() + " A = " + t2.a + " B = " + t2.b + " H = " + t2.h);
            Console.WriteLine("\n\n\n");

            Room r1 = new Room("101", "Building 1", 50);
            Room r2 = new Room("102", "Building 2", 100);
            r1.Show();
            Console.WriteLine("\nThe room number of room 2 is " + r2.roomNumber);
            Console.WriteLine("The Building name  of room 2 is " + r2.buildingName);
            Console.WriteLine("The room capacity of room 2 is " + r2.capacity);
            Console.WriteLine("\n\n\n");
            Vehicle vehicle1 = new Vehicle("Car", 1, 1500);
            Vehicle vehicle2 = new Vehicle("Bike", 2, 1200);
            vehicle1.Show();
            Vehicle vehicle3 = new Vehicle();
            vehicle3.insertVehicle("Bus", 3, 2000);
            vehicle3.Show();
            Console.WriteLine("\n\n\n");
            if (vehicle1.checkWeight())
            {
                Console.WriteLine("The weight of vehicle 1 is greater than 1400");
            }
            else
            {
                Console.WriteLine("The weight of vehicle 1 is less than 1400");
            }
            Console.WriteLine("\n\n\n");
            Vehicle vehicle = new Vehicle();
            Console.WriteLine("Enter the name of the vehicle");
            vehicle.name = Console.ReadLine();
            Console.WriteLine("Enter the ID of the vehicle");
            vehicle.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the weight of the vehicle");
            vehicle.weight = Convert.ToInt32(Console.ReadLine());
            vehicle.Show();

        }
    }
}
