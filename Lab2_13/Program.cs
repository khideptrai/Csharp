class Program
{
    static void Main(string[] args)
    {
        long tienGui, soThang;
        double laiXuat, laiXuatThang;
        double tienLai = 0;
        long totalMoney;
        Console.Write("Nhap so tien gui:");
        tienGui = Convert.ToInt64(Console.ReadLine());
        Console.Write("Nhap lai xuat:");
        laiXuat = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap so thang gui:");
        soThang = Convert.ToInt64(Console.ReadLine());
        if(tienGui > 0 && laiXuat > 0 && soThang > 0)
        {
            laiXuatThang = (laiXuat / 12) / 100;
            totalMoney = tienGui;
            Console.WriteLine("\t\t Thang \t\t Tien goc + lai \t\tTien lai thang");
            for(int i = 1; i<= soThang; i++)
            {
                totalMoney = (int)tienLai+tienGui;
                tienLai = totalMoney * laiXuatThang;
                Console.WriteLine("\t\t {0} \t\t  {1:N} \t\t {2:N}", i, totalMoney, tienLai);

            }
        }
        else
        {
            Console.WriteLine("Thong tin nhap khong hop le");
        }

    }
}