class Program
{
    static void Main(String[] args)
    {
        bool check_i;
        Console.Write("Danh sach cac so nguyen so tu 2-100: ");
        for(int i = 2;i<= 100; i++)
        {
            check_i = true;
            for (int j = 2; j<= i/2; j++)
            {
                if(i % j == 0)
                {
                    check_i = false;
                    break;
                }
            }
            if (check_i)
            {
                Console.Write(" {0} ", i);
            }
        }
        Console.Read();
    }
}