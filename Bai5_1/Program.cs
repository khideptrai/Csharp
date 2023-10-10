using Bai5_1;

class Program
{
    static void Main(string[] args)
    {
        Book sach1 = new Book(1,"Sach 1",1000,"NXB VietNam");
        Console.WriteLine(sach1.ToString());
        sach1.Price = 100;
        Console.WriteLine("Thong tin sach sau khi thay doi:");
        Console.WriteLine(sach1.ToString() );
        Book book2 = new Book();
        Console.WriteLine(book2.ToString());
        Console.Read();
        
    }
}