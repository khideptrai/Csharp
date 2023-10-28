class Program
{
    public static void Main(string[] args)
    {
        ProductEnumerable productEnumerable = new ProductEnumerable();
        foreach(var item in productEnumerable)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}