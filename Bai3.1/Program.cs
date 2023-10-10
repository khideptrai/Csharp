using Bai3._1;

class Program
{
    static void Main(string[] args)
    {
        Utility util = new Utility();
        int []arr;
        arr = new int[10];
        util.ArrayAdd(arr);
        Console.WriteLine("Phan tu nho nhat trong mang la: "+util.SmallestNumber(arr));
        Console.WriteLine("Mang sau khi dao nguoc:");
        util.ReverseArray(arr);
        foreach(int i in arr)
        {
            Console.Write(" " + i);
        }
        util.SortUp(arr);
        Console.WriteLine("\nMang sau khi sap sep tang :");
        foreach(int i in arr)
        {
            Console.Write(" " + i);
        }
        util.ShortDown(arr);
        Console.WriteLine("\nMang sau khi sap sep giam: ");
        foreach(int i in arr)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine("\nCac phan tu la so nguyen to :");
        foreach(int i in arr)
        {
            if (util.PrimeNumber(i))
            {
                Console.Write(" " + i);
            }
        }
        Console.WriteLine("So luong cac so duong lien tiep la: " + util.MaxConsecutivePositive(arr));
        Console.WriteLine("Trung binh cong cac phan tu duong la: " + util.Average(arr));
        if (util.isIntertwined(arr))
        {
            Console.WriteLine("Mang co chua cac phan tu am duong dan xen");
        }
        else
        {
            Console.WriteLine("Mang khong chua cac phan tu am duong dan xen");
        }
    }
}