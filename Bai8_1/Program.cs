public class Program
{
    public static void Main(string[] args)
    {
        Generic<int> test = new Generic<int>(10);
        test.Add(1);
        test.Add(20);
        test.Add(30);
        Console.WriteLine(test.Get(1));
        Console.WriteLine(test.Get(2));
        Console.WriteLine(test.Get(30));
    }
}
