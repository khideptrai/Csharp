class Program
{
    static void Main(String[] args)
    {
        char ch;
        Console.WriteLine("Nhap vao ky tu:");
        ch = (char)Console.Read();
        switch (ch)
        {
            case 'a':
            case 'o':
            case 'e':
            case 'u':
            case 'i':
                Console.WriteLine("{0} la nguyen am.", ch);
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("{0} la phu am.", ch);
                Console.ReadLine();
                break;
        }
        Console.ReadLine();
    }
}