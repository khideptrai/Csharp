using Bai7_1;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        Console.WriteLine("Nhap vao 10 quyen sach");
        for(int i = 0; i < 10; i++)
        {
            Book book1 = new Book();
            Console.WriteLine("Quyen sach thu: " + (i+1));
            Console.WriteLine("Nhap id :");
            book1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Tieu de: ");
            book1.Title = Console.ReadLine();
            Console.WriteLine("Nhap tac gia: ");
            book1.Author = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban: ");
            book1.Publisher = Console.ReadLine();
            Console.WriteLine("Nhap nam xuat ban");
            book1.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia:");
            book1.Price = Convert.ToInt32(Console.ReadLine());
            books.Add(book1);
        }
        Console.WriteLine("Danh sach cac quyen sach tang dan theo gia: ");
        books = books.OrderBy(x => x.Price).ToList();
        foreach(Book book in books)
        {
            Console.WriteLine(book.ToString());
        }
        Console.WriteLine("Nhap tieu de quyen sach muon tim: ");
        string title = Console.ReadLine();
        Book FindBook = books.Find(x => x.Title == title);
        if(FindBook != null)
        {
            Console.WriteLine(FindBook.ToString());
        }else { Console.WriteLine("Khong co quyen sach nao co tieu de nhu vay"); }
        Console.WriteLine("Nhung quyen sach xuat ban nam 2014 la: ");
        foreach(Book book in books)
        {
            if(book.Year == 2014)
            {
                Console.WriteLine(book.ToString());
            }
        }
        books.RemoveAll(x => x.Publisher.Equals("Nhi Dong"));
        Console.WriteLine("Danh sach cac quyen sach sau khi xoa cac quyen sach co nha xuat ban Nhi Dong");
        foreach (Book book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }
}