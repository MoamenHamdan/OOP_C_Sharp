using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace_software
{
    internal class TestEmployee
    {
        public static void Main(string[] args)
        {
            // Create two Employee objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();


            Console.WriteLine("Enter the information about your employee:");
            Console.Write("Employee name: ");
            string name1 = Console.ReadLine();
            Console.Write("Basic salary: ");
            double basicSalary1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gross sale: ");
            double grossSales1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Commission rate: ");
            double commissionRate1 = Convert.ToDouble(Console.ReadLine());
            employee1.InsertRecord(name1, basicSalary1, grossSales1, commissionRate1);


            Console.WriteLine("Enter the information about your employee:");
            Console.Write("Employee name: ");
            string name2 = Console.ReadLine();
            Console.Write("Basic salary: ");
            double basicSalary2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gross sale: ");
            double grossSales2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Commission rate: ");
            double commissionRate2 = Convert.ToDouble(Console.ReadLine());
            employee2.InsertRecord(name2, basicSalary2, grossSales2, commissionRate2);


            Console.WriteLine($"Number of employees: {Employee.GetEmployeeNumber()}");
            Console.WriteLine("Employee information:");
            employee1.Display();
            employee2.Display();
        }
    }
}
