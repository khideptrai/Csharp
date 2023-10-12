using Bai3_5;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.Display();
        Book book2 = new Book("David", 99, "34567898", "Sach", 5);
        book2.Display();
        book2.FlipPageForward();
        Console.WriteLine("Trang hien tai sau khi lat sang truoc: " + book2.currentPage);
        book2.FlipPageBackward();
        Console.WriteLine("Trang hien tai sau khi lat trang sau: " + book2.currentPage);
    }
}