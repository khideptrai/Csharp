class Program
{
    static void Main(string[] args)
    {
        Contact ct1 = new Contact();
        ct1.Id = 1;
        ct1.Firtsname = "Nguyen Thi";
        ct1.Lastname = "Hoa";
        ct1.Address = "Ha Noi";
        ct1.Phone = "081234123";
        ct1.Email = "nguyenthihoa@gmail.com";
        Contact ct2 = new Contact(2, "Tran Thi", "Vinh", "Ha Noi", "091231234", "tranthivinh@gmail.com");
        ct1.Display();
        ct2.Display();
    }
}