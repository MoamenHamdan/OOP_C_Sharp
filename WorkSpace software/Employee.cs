using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace_software
{

    public class Employee
    {
        private static int employeeNumber = 0; 
        private int id; 
        private string name;
        private double basicSalary;
        private double grossSales;
        private double commissionRate;

   
        public Employee()
        {
            this.name = "unknown";
            this.basicSalary = 0;
            this.grossSales = 0;
            this.commissionRate = 0;
            this.id = ++employeeNumber; 
        }

      
        public Employee(string name, double basicSalary, double grossSales, double commissionRate)
        {
            this.name = name;
            this.basicSalary = basicSalary;
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
            this.id = ++employeeNumber; 
        }

      
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static int GetEmployeeNumber()
        {
            return employeeNumber;
        }

        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }

        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

       
        public void InsertRecord(string name, double basicSalary, double grossSales, double commissionRate)
        {
            this.name = name;
            this.basicSalary = basicSalary;
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }

        
        public double CalculateEarnings()
        {
            return (grossSales * commissionRate) / 100;
        }

      
        public double TotalIncome()
        {
            return basicSalary + CalculateEarnings();
        }

       
        public void Display()
        {
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Basic salary: {basicSalary}");
            Console.WriteLine($"Grants and bonuses: {CalculateEarnings()}$");
            Console.WriteLine($"Total income: {TotalIncome()}$");
            Console.WriteLine();
        }
    }
}
