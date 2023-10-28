using System.Collections;

public class ProductEnumerable:IEnumerable
{
    string[] SanPham = { "San Pham A" , "San Pham B" , "San Pham C" , "San Pham D" , "San Pham E" };
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < SanPham.Length; i++)
        {
            yield return SanPham[i];
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        ProductEnumerable productEnumerable = new ProductEnumerable();
        foreach(var item in productEnumerable)
        {
            Console.WriteLine(item);
        }
    }
}