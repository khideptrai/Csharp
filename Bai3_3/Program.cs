class Program
{
    static void Main(string[] args)
    {
        string[] CAN = { "Giap", "At", "Binh", "Dinh", "Mau", "Ky", "Canh", "Tan", "Nham", "Quy" };
        string[] Chi = { "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui", "Than", "Dau", "Tuan", "Hoi" };
        List<string> CanChi = new List<string>();
        int year;
        Console.WriteLine("Nhap nam :");
        year = Convert.ToInt32(Console.ReadLine());
        int tinhCan = year % 10;
        int tinhChi = year % 12;
        Console.WriteLine("Nam am tuong ung cua nam {0} la: {1} {2}", year, CAN[tinhCan], Chi[tinhChi]);
    }
}