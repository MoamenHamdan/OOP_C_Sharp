using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class GeometricObject
    {
        private String color;
        private bool filled;
        private DateTime dateCreated;

        public GeometricObject()
        {
            dateCreated = DateTime.Now;
        }
        public GeometricObject(string color , bool filled )
        {
            this.color = color;
            this.filled = filled;
            dateCreated = DateTime.Now;
        }
       

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }
        public DateTime DateCreated { get { return dateCreated; } }

        public override string ToString()
        {
            return "created on " + dateCreated + "\ncolor: " + color + " and filled: " + filled;
        }


    }
}
