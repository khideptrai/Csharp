using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_4
{
    class Person
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + ", Email: " + Email;
        }
    }

    class Student : Person
    {
        public string StudyProgram { get; set; }

        public override string ToString()
        {
            return "Student: " + Name + ", Email: " + Email + ", Program: " + StudyProgram;
        }
    }

    class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }

        public override string ToString()
        {
            return "Employee: " + Name + ", Email: " + Email;
        }

        public virtual double CalculateBonus()
        {
            return 0;
        }

        public virtual int CalculateVacation()
        {
            return 0;
        }
    }

    class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }

        public override string ToString()
        {
            return "Faculty: " + Name + ", Email: " + Email;
        }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }

        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - DateHired.Year;
            if (yearsEmployed >= 3)
            {
                return (Rank == "Senior Lecturer") ? 5 : 4;
            }
            return 0;
        }
    }

    class Staff : Employee
    {
        public string Title { get; set; }

        public override string ToString()
        {
            return "Staff: " + Name + ", Email: " + Email;
        }

        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }

        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - DateHired.Year;
            return (yearsEmployed >= 5) ? 4 : 3;
        }
    }
}
