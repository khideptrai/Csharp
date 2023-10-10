
using Bai3_2;

class Program
{
    static void Main(string[] args)
    {
        Utility util = new Utility();
        int[,] mang = new int[4, 4];
        util.addArray(mang);
        Console.WriteLine("Mang theo hang cot:");
        util.showArray(mang);
        Console.WriteLine("Tong cac phan tu co chi so hang bang chi so cot: " + util.SumArray(mang));
        Console.WriteLine("Cac phan tu nho nhat tren cot la: ");
        util.Smallest(mang);
        Console.WriteLine("\nCac phan tu chia het cho 7 :");
        for(int i = 0;i< mang.GetLength(0); i++)
        {
            for(int j =0;j< mang.GetLength(1); j++)
            {
                if (mang[i,j] % 7 == 0)
                {
                    Console.WriteLine(mang[i, j] + "\t");
                }
            }
        }
        Console.WriteLine("Tong cac phan tu nam tren duong vien cua mang la :" + util.SumArray1(mang));
        int[] arr;
        arr = new int[mang.GetLength(0)*mang.GetLength(1)];
        util.SwapArray(mang, arr);
        util.SortUp(arr);
        Console.WriteLine("Mang 1 chieu sau khi sap xep tang dan:");
        for(int i = 0;i< arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }


}