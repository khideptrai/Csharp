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
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}