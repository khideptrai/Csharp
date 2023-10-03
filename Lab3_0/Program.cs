class Program
{
    static void Main(string[] args)
    {
        int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
        //duyet mang va in du lieu
        Console.Write("Cac phan tu cua mang:");
        for(int i = 0;i< m.Length; i++)
        {
            Console.Write(" {0}", m[i]);
        }
        //tim phan tu lon nhat
        int max = m[0];
       for(int i = 0;i < m.Length; i++)
        {
            if(max < m[i])
            {
                max = m[i];
            }
        }
        Console.WriteLine("\nPhan tu lon nhat:" + max);
        //kiem tra mang co doi xung khong?
        bool kt = true;
        for(int i = 0; i < m.Length/2; i++)
        {
            if (m[i] != m[m.Length - 1 - i])
            {
                kt = false;
                break;
            }
        }
        if (kt)
        {
            Console.WriteLine("Mang doi xung");
        }
        else
        {
            Console.WriteLine("Mang khong doi xung");
        }
        Console.Read();
    }
}