class Program
{
    public static void Main(string[] args)
    {
        int n, m;
        Func<int, bool> IsPrime = delegate(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        };
        Func<int, int, int> Total = delegate (int n, int m)
        {
            int total = 0;
            for (int i = n; i < m; i++)
            {
                total += i;
            }
            return total;
        };
        Console.WriteLine("Nhap vao so N");
        n = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} la mot so nguyen to");
        }
        else
        {
            Console.WriteLine($"{n} khong phai so nguyen to");
        }
        Console.WriteLine("Nhap vao so M");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tong cac so tu N den M la: "+Total(n,m));
        Console.Read();
  
    }
}