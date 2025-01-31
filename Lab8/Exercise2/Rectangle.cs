using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Rectangle : GeometricObject
    {

		private double width;
		private double  height;

		public double  Height
		{
			get { return height; }
			set { height = value; }
		}

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return "Rectangle with width " + width + " and height " + height + " and " + base.ToString();

        }

        public double GetArea()
        {
            return width * height;
        }

        public Rectangle (double width , double height ,string color , bool filled ) :base (color , filled)
        {
            this.width = width;
            this.height = height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }





        }
}
