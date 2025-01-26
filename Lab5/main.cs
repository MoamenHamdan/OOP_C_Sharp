using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class main
    {
        static void Main(string[] args)
        {
           Student s1 = new Student(202001234, "ali", 3.5, 'M');
           Student s6 = new Student();
            Console.WriteLine("Enter the id of the student : ");
            s6.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the student : ");
            s6.Name = Console.ReadLine();
            Console.WriteLine("Enter the gpa of the student : ");
            s6.Gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Gender of the student : ");    
            s6.Gender = char.Parse(Console.ReadLine());


            Console.WriteLine(s1.ToString());
            Console.WriteLine("After filling in the student's information has the following \n" + s6.ToString());
            
            Console.WriteLine("Student comparison : ");
            if (s1.status() && s6.status())
            {
                Console.WriteLine("Both students are in good standing");
            }
            else if (s1.status() && !s6.status())
            {
                Console.WriteLine("Student 1 is in good standing and student 2 is not in good standing");
            }
            else
            {
                Console.WriteLine("Both students are not in good standing");
            }


            if (s1.scholarship() > s6.scholarship())
            {
                Console.WriteLine(s1.Name + " has a higher scholarship than " + s6.Name);
            }
            else if (s1.scholarship() < s6.scholarship())
            {
                Console.WriteLine(s6.Name + " has a  " +s6.Gpa + "higher scholarship than " + s1.Gpa + " of " + s1.Name);
            }
            else
            {
                Console.WriteLine("Both students have the same scholarship");
            }

            if (s1.yearOfEnterance() > s6.yearOfEnterance())
            {
                Console.WriteLine(s1.Name + " entered the university before " + s6.Name);
            }
            else if (s1.yearOfEnterance() < s6.yearOfEnterance())
            {
                Console.WriteLine(s6.Name + " entered the university before " + s1.Name);
            }
            else
            {
                Console.WriteLine("Both students entered the university at the same time");
            }

            Console.WriteLine(s1.Name + " start university in " + s1.yearOfEnterance());
            Console.WriteLine(s6.Name + " start university in " + s6.yearOfEnterance());






        }
    }
}
