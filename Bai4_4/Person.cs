using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_4
{
    class Person
    {
        private string name;
        private int phone;
        private string email;

        public override string ToString()
        {
            return "Class Name: "+GetType() +" Name: "+ Name +" Email: "+ Email;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
    class Student : Person
    {
        private string studyProgram;
 
        public string StudyProgram {  get { return studyProgram; } set {  studyProgram = value; } }
    }
    class Employee : Person
    {
        private string department;
        private double salary;
        private DateTime datehired;
 
        public string Department {  get { return department; } set { department = value; } }
        public double Salary { get {  return salary; } set {  salary = value; } }
        public DateTime Datehired { get {  return datehired; } set {  datehired = value; } }
        public virtual double CalculateBonus()
        {
            return 0;
        }
        public virtual int CalculateVacation() { return 0; }
    }
    class Faculty : Employee
    {
        private double officeHours;
        private string rank;
  
        public double OfficeHours {  get { return officeHours; } set { officeHours = value; } }
        public string Rank { get { return rank; } set { rank = value; } }
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }
        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - Datehired.Year;
            if (yearsEmployed >= 3)
            {
                if(Rank == "Senior Lecturer")
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
            else { 
                return 4;
            }
        }
    }
    class Staff : Employee
    {
        private string title;
        public string Title { get { return title; } set { title = value; } }
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }
        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - Datehired.Year;
            if (yearsEmployed >= 5)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
    }
}
