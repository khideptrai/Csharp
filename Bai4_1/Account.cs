using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bai4_1
{
    class Account
    {
        protected double Balance;
        protected double Initialize;
        public Account(double Initialize)
        {
            this.Initialize = Initialize;
            Balance = Initialize;
        }
        public virtual void Deposit(double money)
        {
            if(money > 0)
            {
                Balance += money;
                Console.WriteLine("Ban da gui thanh cong so tien {0}, Tai khoan ban hien tai co: {1}", money, Balance);
            }
            else
            {
                Console.WriteLine("So tien gui can lon hon 0");
            }
        }
        public virtual void WithDraw(double money)
        {
            if(Balance == 0)
            {
                Console.WriteLine("Tai khoan cua ban khong co tien de rut");
            }
            else if(money < 0)
            {
                Console.WriteLine("So tien can rut khong hop le");
            }
            else if(Balance - money < 0)
            {
                Console.WriteLine("So du tai khong dap ung yeu cau rut cua ban");
            }
            else
            {
                Balance -= money;
                Console.WriteLine("Ban da rut thanh cong so tien {0},So du con lai cua ban la: {1}", money, Balance);
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
    class SavingAccount : Account
    {
        protected double rate;
        public SavingAccount(double Initialize, double rate) : base(Initialize)
        {
            this.rate = rate;
        }
        public double GetInterest()
        {
            return Balance * rate;
        }
    }
    class CheckAccount : Account
    {
        protected double FeeTransfer;
        public CheckAccount(double Initialize,double FeeTransfer) : base(Initialize)
        {
            this.FeeTransfer = FeeTransfer;
        }
        public override void Deposit(double money)
        {
            base.Deposit(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Nap tien thanh cong, ban bi tru {FeeTransfer} tien phi");
        }
        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Rut tien thanh cong, ban bi tru {FeeTransfer} tien phi");
        }
        public new double GetBalance()
        {
            Balance -= FeeTransfer;
            Console.WriteLine($"Kiem tra tai khoan thanh cong, ban bi tru {FeeTransfer} tien phi");
            return Balance;
        }
    }
}
