using Bai4_1;

class Program
{
    public static void Main(string[] args)
    {
        Account acc1 = new Account(50000);
        acc1.Deposit(500);
        acc1.WithDraw(5000);
        Console.WriteLine($"So tien trong tai khoan 1 hien tai co la {acc1.GetBalance()}");
        SavingAccount acc2 = new SavingAccount(100000, 5);
        acc2.Deposit(1000);
        Console.WriteLine($"So tien trong tai khoan 2 hien tai co la {acc1.GetBalance()}");
        Console.WriteLine($"So tien lai hien tai la: {acc2.GetInterest()}");
        CheckAccount acc3 = new CheckAccount(1000000,500);
        acc3.Deposit(150000);
        acc3.WithDraw(500000);
        Console.WriteLine($"So tien trong tai khoan 3 hien co la: {acc3.GetBalance()}");
    }
}