class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.Write("Nhap so nguyen a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so nguyen b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so nguyen c:");
        c = Convert.ToInt32(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            if ((a + b > c) || (a + c > b) || (b + c > a))
            {
                Console.WriteLine("Day la 3 canh cua tam giac");
                if (a == b && b == c)
                {
                    Console.WriteLine("Va la tam giac deu");
                }
                else if (a == b && a != c)
                {
                    Console.WriteLine("Va la tam giac can");
                }
                else if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) || (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2)))
                {
                    Console.WriteLine("Va la tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Va la tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai la 3 canh cua tam giac");
            }
        }
    } 
}