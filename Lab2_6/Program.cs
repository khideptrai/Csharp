class Program
{
    static void Main(String[] args)
    {
        string[] names = { "Thang", "Long", "Hoa", "Dao" };
        Console.Write("Danh sach sinh vien: \n");
        foreach(var n in names)
        {
            Console.WriteLine(n);
        }
        Console.Read();
    }
}