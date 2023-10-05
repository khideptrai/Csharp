class Program
{
    static void Main(string[] args)
    {
        int n = 11;
        for(int i = 0;i < n; i++)
        {
            for(int j = 0; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for(int j = i;j <= 2 * i - 1; j++)
            {
                int temp = j;
                if(temp > 9)
                {
                    temp = temp % 10;
                }
                Console.Write(temp);
            }
            for(int j = 2 * i - 2;j >= i;j--)
            {
                int temp = j;
                if (temp > 9)
                {
                    temp = temp % 10;
                }
                Console.Write(temp);
            }
            Console.WriteLine();       
        }
        Console.Read();
    }
}