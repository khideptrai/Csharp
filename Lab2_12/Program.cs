class Program
{
    static void Main(string[] args)
    {
        for(int i = 1;i < 11; i++)
        {
            for(int j = 1; j <= 11-i; j++)
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
    }
}