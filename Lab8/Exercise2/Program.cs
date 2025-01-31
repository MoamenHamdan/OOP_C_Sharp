using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("how many objects you want to enter ? ");
            int n = int.Parse(Console.ReadLine());
            GeometricObject[] geometricObjects = new GeometricObject[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter 1 for Circle and 2 for Rectangle");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the color of the circle");
                    string color = Console.ReadLine();
                    Console.WriteLine("Enter the radius of the circle");
                    double radius = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Enter true if the circle is filled and false if it is not filled");
                    bool filled = bool.Parse(Console.ReadLine());
                    geometricObjects[i] = new Circle(radius, color, filled);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the width of the rectangle");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the rectangle");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the color of the rectangle");
                    string color = Console.ReadLine();
                    Console.WriteLine("Enter true if the rectangle is filled and false if it is not filled");
                    bool filled = bool.Parse(Console.ReadLine());
                    geometricObjects[i] = new Rectangle(width, height, color, filled);
                }
            }
            Console.WriteLine("All the objects available are : ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Object " + (i + 1));
                
                Console.WriteLine(geometricObjects[i].ToString());
                if(geometricObjects[i] is Circle)
                {
                    Console.WriteLine("Diameter : " + ((Circle)geometricObjects[i]).GetDiameter());
                    Console.WriteLine("Radius : " + ((Circle)geometricObjects[i]).Radius);
                }
                else if (geometricObjects[i] is Rectangle)
                {
                Console.WriteLine("Area : " + ((Rectangle)geometricObjects[i]).GetArea());
                Console.WriteLine("Perimeter : " + ((Rectangle)geometricObjects[i]).GetPerimeter());
                    Console.WriteLine("Height : " + ((Rectangle)geometricObjects[i]).Height );
                    Console.WriteLine("Width : " + ((Rectangle)geometricObjects[i]).Width);
                }
              
            }


        }
    }
}
