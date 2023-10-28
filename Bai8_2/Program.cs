class Program
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    public static void Main(string[] args)
    {
        int a ,b ;
        Console.WriteLine("Nhap vao so A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao so B");
        b = Convert.ToInt32(Console.ReadLine());
        Swap<int>(ref a ,ref b);
        Console.WriteLine("So A sau khi swap la {0}\n So B sau khi swap la {1}",a,b);
    }
}