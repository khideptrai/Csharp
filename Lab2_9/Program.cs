class Program
{
    static void Main(string[] args)
    {
        int sum, digital1,digital2,digital3;
        for(int i = 100; i <= 999; i++)
        {
            digital1 = i / 100;
            digital2 = (i / 10)% 10;
            digital3 = i % 10;
            sum = digital1 + digital2 + digital3;
            if(sum % 2== 0)
            {
                Console.Write(" " + i);
            }
        }
    }
}