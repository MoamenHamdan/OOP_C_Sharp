using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Student : Person
    {
		private int numCourses;
		private int[]  grades;
		private string[]  courses;



        public Student()
        {
            numCourses = 0;
            courses = new string[30];
            grades = new int[5];
        }

        public Student(string name, string address) : base(name, address)
        {
            numCourses = 0;
            courses = new string[30];
            grades = new int[5];
        }

        public string[]  Courses
		{
			get { return courses; }
			set { courses = value; }
		}


		public int[]  Grades
		{
			get { return grades; }
			set { grades = value; }
		}


		public int NumCourses
        {
			get { return numCourses; }
			set { numCourses = value; }
		}

		public void AddCourseGrade(string course, int grade)
        {
            grades[numCourses] = grade;
            courses[numCourses] = course;
            numCourses++;
        }

        public void PrintGrades()
        {
            //Console.Write(this);
            for (int i = 0; i < numCourses; i++)
            {
                Console.Write(" " + courses[i] + ":" + grades[i]);
            }
            Console.WriteLine();
        }

        public double GetAverageGrade()
        {
            int sum = 0;
            for (int i = 0; i < numCourses; i++)
            {
                sum += grades[i];
            }
            return (double)sum / numCourses;
        }

        public override string ToString()
        {
            return "Student: " + base.ToString();
        }


    }
}
