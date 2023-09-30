class Program
{
    static void Main(String[] args)
    {
        int thang, nam;
        int ngay = 0;
        Console.Write("Nhap nam:");
        nam = Convert.ToInt16(Console.ReadLine());
        Console.Write("Nhap thang:");
        thang = Convert.ToInt16(Console.ReadLine());
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                ngay = 31;
                break;
            case 2:
                if(nam % 4 == 0)
                {
                    ngay = 29;
                }
                else
                {
                    ngay = 28;
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                ngay = 30;
                break;
            default:
                Console.WriteLine("Thang khong chinh xac");
                break;
        }
        Console.WriteLine("Thang {0} Nam {1} co {2} ngay",thang,nam,ngay);
        Console.Read();

    }
}