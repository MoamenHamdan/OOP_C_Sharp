using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Teacher : Person
    {
		private int numCourses;
		private string[] courses;
		public string[] Courses
        {
			get { return courses; }
			set { courses = value; }
		}


		public int NumCourses
        {
			get { return numCourses; }
			set { numCourses = value; }
		}

        public Teacher()
        {
            numCourses = 0;
            courses = new string[5];
        }

        public Teacher(string name, string address) : base(name, address)
        {
            numCourses = 0;
            courses = new string[5];
        }

        public override string ToString()
        {
            return "Teacher: " + base.ToString();
        }

        public bool AddCourse(string course)
        {
            for (int i = 0; i < numCourses; i++)
            {
                if (courses[i].Equals(course))
                {
                    return false;
                }
            }
            courses[numCourses] = course;
            numCourses++;
            return true;
        }

        public bool RemoveCourse(string course)
        {
            bool found = false;
            int courseIndex = -1;
            for (int i = 0; i < numCourses; i++)
            {
                if (courses[i].Equals(course))
                {
                    courseIndex = i;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                for (int i = courseIndex; i < numCourses - 1; i++)
                {
                    courses[i] = courses[i + 1];
                }
                numCourses--;
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
