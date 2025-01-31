using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Campus
    {
        public string address { get; set; }

        Building Building { get; set; } 
        public Campus() { }

        public Campus(string address ,Building b )
        {
            this.address = address;
            Building = b;   
        }   
        public void Display (){ 
        
            Console.WriteLine("The Campus is located at " + address + "and has "+Building.numberOfFloors + " and " + Building.numberOfRooms);

        }

        
    }


}
