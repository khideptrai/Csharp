namespace Bai4_4
{
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
}
