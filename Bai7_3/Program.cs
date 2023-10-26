using Bai7_3;

class Program
{
    public static void Main(string[] args)
    {
        List<Car> car = new List<Car>();
        for (int i = 0;i< 10; i++)
        {
            Console.WriteLine("Nhap thong tin xe "+(i+1));
            Car car_1 = new Car();
            Console.WriteLine("Nhap ten xe: ");
            car_1.Name = Console.ReadLine();
            Console.WriteLine("Nhap mau xe: ");
            car_1.Color = Console.ReadLine();
            car.Add(car_1);
        }
        car.RemoveAll(x => x.Color.Equals("Red"));
        Console.WriteLine("Danh sach xe sau khi xoa nhung xe co mau do: ");
        foreach(var item in car)
        {
            Console.WriteLine(item.ToString);
        }
    }
}