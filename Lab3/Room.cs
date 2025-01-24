using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Room
    {
      public  string roomNumber;
        public string buildingName;
        public int capacity;

        public Room()
        {
            Console.WriteLine("Static Constructor Called");
        }
        public Room(string roomNumber ,string buildingName , int capacity)
        {
            this.roomNumber = roomNumber;
            this.buildingName = buildingName;
            this.capacity = capacity;
        }
        public void Show()
        {
            Console.WriteLine("Room Number : " + roomNumber);
            Console.WriteLine("Building Name : " + buildingName);
            Console.WriteLine("Capacity : " + capacity);
        }

    }
}
