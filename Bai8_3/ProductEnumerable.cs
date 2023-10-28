using System.Collections;

public class ProductEnumerable
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
