using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Trapizoid
    {
        public double a;
        public double b;
        public double h;

        public Trapizoid()
        {
            this.a = 0;
            this.b = 0;
            this.h = 0;
        }
        public Trapizoid(double base1, double base2, double height)
        {
            this.a = base1;
            this.b = base2;
            this.h = height;
        }
        public double Area()
        {
            return (a + b) * h / 2;
        }
    }
}
