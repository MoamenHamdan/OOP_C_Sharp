using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Vehicle
    {
        public string name;
        public int id; 
        public int weight;

        public Vehicle()
        {
            this.name = " ";
            this.id = 0;
            this.weight = 0;
        }
        public Vehicle(string name, int id, int weight)
        {
            this.name = name;
            this.id = id;
            this.weight = weight;
        }
        public void Show()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Weight : " + weight);
        }
        public void insertVehicle(string name, int id, int weight)
        {
            this.name = name;
            this.id = id;
            this.weight = weight;
        }
        public bool checkWeight()
        {
            if (weight > 1400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
