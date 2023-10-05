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
            Console.WriteLine("{0:00}:{1:00}:{2:00}", hour, minute, seconds_1);
        }
        else
        {
            Console.WriteLine("Vui long nhap so nguyen duong");
        }
        Console.Read();
    }
}