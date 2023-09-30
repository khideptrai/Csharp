class Program
{
    static void Main(String[] args)
    {
        int ngay, thang, nam;
        Console.Write("Nhap nam:");
        nam = Convert.ToInt16(Console.ReadLine());
        Console.Write("Nhap thang:");
        thang = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Nam: {0} Thang {0}", nam, thang);
        Console.Read();

    }
}