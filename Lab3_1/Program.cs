///<summary>
///Chuong trinh minh hoa mot so thao tac tren mang 2 chieu
/// </summary>
/// <param name="args"></param>
class Program
{
    static void Main(string[] args)
    {
        //khai bao va khoi tao mang
        int[,] a = { { 4, 6, 9 }, { 2, 4, 5 }, { 9, 2, 6 }, { 1, 6, 3 } };
        //duyet mang va in theo hang cot
        Console.WriteLine("Noi dung mang:");
        for(int i = 0;i <= a.GetUpperBound(0); i++)
        {
            Console.WriteLine();
            for(int j = 0;j<= a.GetUpperBound(1); j++)
            {
                Console.WriteLine("{0}", a[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nCac phan tu co chi hang bang chi so cot:");
        for(int i = 0;i<= a.GetUpperBound(0); i++)
        {
            for(int j = 0;j<= a.GetUpperBound(1); j++)
            {
                if (i == j)
                {
                    Console.Write(" {0}", a[i, j]);
                }
            }
        }
        Console.WriteLine("\nCac phan tu lon nhat tren hang");
        for(int i = 0;i<= a.GetUpperBound(0); i++)
        {
            int max = a[i, 0];
            for(int j =0;j<= a.GetUpperBound(1); j++)
            {
                if(max < a[i, j])
                {
                    max = a[i, j];
                }
            }
            Console.WriteLine("Hang {0}:{1}", i, max);
        }
        Console.Read();
    }
}