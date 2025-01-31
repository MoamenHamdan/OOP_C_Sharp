using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Building building = new Building( 11, 120);
            Campus campus = new Campus("Beirut " , building);
            campus.Display();
        }
    }
}
