using Lab3_6;

class Program
{
    static void Main(string[] args)
    {
        int a = 20, b = 30;
        double area;
        Utility util = new Utility();
        Console.WriteLine("Truoc khi hoan vi a ={0} b ={1}");
        util.SwapFake(a, b);
        Console.WriteLine("Sau khi hoan vi fake a={0} b ={1}");
        util.SwapReally(ref a,ref b);
        Console.WriteLine("Sau khi hoan vi real a ={0} b ={1}");
        util.AreaCircle(100, out area);
        Console.WriteLine("Chu vi hinh tron co ban kinh 100 la {0}", area);
    }
}