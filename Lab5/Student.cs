using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Student
    {
        private int id;
        private string name;
        private double gpa;
        private char gender;

        public Student()
        {
            id = 0;
            name = "";
            gpa = 0.0;
            gender= 'N';
        }
        public Student(int id, string name, double gpa , char gender)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
            this.gender = gender;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public override string ToString()
        {
            return "ID: " + id + " Name: " + name + " GPA: " + gpa + "Gender: " + gender;
        }
        public bool status()
        {
            if (gpa > 2)
            {
               return true;
            }
            else
            {
                return false;  
            }
        }
        public int yearOfEnterance()
        {
            string numberStr = id.ToString();
            string year = numberStr.Substring(0 , 4 );
            return int.Parse(year); 
        }
        public double scholarship()
        {
            if (gpa >=2 && gpa <3)
            {
                if(yearOfEnterance() < 2020)
                {
                    return 0.35;
                }
                else
                {
                    return 0.6;
                }
            }
            else if (gpa > 3)
            {
                if(yearOfEnterance() < 2020)
                {
                    return 0.7;
                }
                else
                {
                    return 0.8;
                }
            }
            else
            {
                return 0;
            }
        }

        }
}
