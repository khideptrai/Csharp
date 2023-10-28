namespace Bai4_4
{
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
}
