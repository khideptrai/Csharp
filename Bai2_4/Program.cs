class Program
{
    static void Main(string[] args)
    {
        for(int i = 0;i< 6; i++)
        {
            for(int j = 0;j<= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int i = 0; i < 6; i++)
        {
            for(int j = 5;j>= i; j--)
            {
                Console.Write("$");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int n = 6;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i * 2 + 1; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
        Console.Read();
    }
}