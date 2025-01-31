using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Building
    {
        public int numberOfFloors { get; set; }
        public int numberOfRooms { get; set; }

        public Building(int numberOfFloors, int numberOfRooms)
        {
            this.numberOfFloors = numberOfFloors;
            this.numberOfRooms = numberOfRooms;
        }

        public void Display()
        {
            Console.WriteLine("The building has " + numberOfFloors + " floors and " + numberOfRooms + " rooms.");
        }
    }
}
