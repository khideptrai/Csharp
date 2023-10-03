using Lab3_2;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.make = "Toyota";
        myCar.model = "MR2";
        myCar.color = "black";
        myCar.year = 1995;
        //hien thi thong tin ve doi tuong myCar
        System.Console.WriteLine("Thong tin chi tiet:");
        System.Console.WriteLine("Make: " + myCar.make);
        System.Console.WriteLine("Model: " + myCar.model);
        System.Console.WriteLine("Color: " + myCar.color);
        System.Console.WriteLine("Year release: " + myCar.year);
        myCar.Start();
        myCar.Stop();
        Console.Read();
    }
}