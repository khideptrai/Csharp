class Program
{
    static void Main(string[] args)
    {
        string id,name, address;
        DateTime birthday;
        double salary, bonus,totalSalary;
        Console.WriteLine("Nhap ma so:");
        id = Console.ReadLine();
        Console.WriteLine("Nhap ten:");
        name = Console.ReadLine();
        Console.WriteLine("Nhap dia chi:");
        address = Console.ReadLine();
        Console.WriteLine("Nhap ngay sinh:");
        birthday = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Nhap luong co ban:");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap tien thuong:");
        bonus = Convert.ToDouble(Console.ReadLine());
        /// tong luong
        totalSalary = salary + bonus;
        Console.WriteLine("\n Thong tin nhan vien");
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Ho va ten: {0}", name);
        Console.WriteLine("Dia chi: {0}", address);
        Console.WriteLine("Ngay sinh: {0:dd/MM/yyyy}", birthday);
        Console.WriteLine("Luong co ban: {0:N}", salary);
        Console.WriteLine("Tien thuong: {0:N}", bonus);
        Console.WriteLine("Tong luong: {0:N}", totalSalary);
        Console.Read();

    }
}