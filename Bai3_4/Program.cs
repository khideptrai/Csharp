using Bai3_4;

class Program
{
    static void Main(string[] args)
    {
        Employee nv = new Employee();
        Console.Write("Nhap Id: ");
        nv.id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ho va ten: ");
        nv.name = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        nv.yearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap bac luong: ");
        nv.salaryLevel = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap muc luong co ban:");
        nv.basicSalary = Convert.ToDouble(Console.ReadLine());
        nv.Display();
    }
}