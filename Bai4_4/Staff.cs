namespace Bai4_4
{
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
