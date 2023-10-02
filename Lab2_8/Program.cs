class Program
{
    static void Main(string[] args)
    {
        int seconds, hour, minute;
        Console.WriteLine("Nhap so giay:");
        seconds = Convert.ToInt32(Console.ReadLine());
        if(seconds >= 0)
        {
            hour = seconds / 3600;
            minute = (seconds % 3600) / 60;
            int seconds_1 = seconds % 60;
            string ketQua = string.Format("{0:00}:{1:00}:{2:00}", hour, minute, seconds_1);
            Console.WriteLine(ketQua);
        }
        else
        {
            Console.WriteLine("Vui long nhap so nguyen duong");
        }
        Console.Read();
    }
}