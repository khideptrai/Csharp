using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_4
{
    class Employee
    {
        public int id;
        public string name;
        public int yearOfBirth;
        public double salaryLevel;
        public double basicSalary;
        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void Display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nam sinh: " + yearOfBirth);
            Console.WriteLine("Luong co ban: " + basicSalary);
            Console.WriteLine("Thu nhap: " + GetIncome());
        }
    }
}
