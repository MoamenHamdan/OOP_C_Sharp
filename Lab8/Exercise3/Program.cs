using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddCourseGrade("IM101", 97);
            student.AddCourseGrade("IM102", 68);

            Console.WriteLine("Student Grades:");
            student.PrintGrades();

            Console.WriteLine($"Average Grade: {student.GetAverageGrade()}");

            
            Teacher teacher = new Teacher();
            if (teacher.AddCourse("IM101"))
            {
                Console.WriteLine("IM101 added");
            }
            else
            {
                Console.WriteLine("IM101 cannot be added");
            }

            if (teacher.AddCourse("IM102"))
            {
                Console.WriteLine("IM102 added");
            }
            else
            {
                Console.WriteLine("IM102 cannot be added");
            }

            if (teacher.RemoveCourse("IM101"))
            {
                Console.WriteLine("IM101 removed");
            }
            else
            {
                Console.WriteLine("IM101 cannot be removed");
            }

            if (teacher.RemoveCourse("IM102"))
            {
                Console.WriteLine("IM102 removed");
            }
            else
            {
                Console.WriteLine("IM102 cannot be removed");
            }
        }
    }


}
