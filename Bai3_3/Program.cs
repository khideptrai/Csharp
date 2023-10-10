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
        for(int i = 0; i < CAN.Length; i++)
        {
            if(i == tinhCan)
            {
                CanChi.Add(CAN[i]);
            }
        }
        for(int j = 0;j< Chi.Length; j++)
        {
            if(j == tinhChi)
            {
                CanChi.Add(Chi[j]);
            }
        }
        Console.WriteLine("Nam am tuong ung cua nam {0} la:");
        foreach(string str in CanChi)
        {
            Console.Write(str+ " ");
        }

        

    }
}