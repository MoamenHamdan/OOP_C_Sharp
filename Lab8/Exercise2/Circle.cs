using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Circle : GeometricObject
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return "Circle with radius " + radius + " and " + base.ToString();
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }   

        public double GetDiameter()
        {
            return 2 * radius;
        }



    }
}
