using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_1
{
    class Account
    {
        protected double Balance;
        protected double Initialize;
        public Account(double Initialize)
        {
            this.Initialize = Initialize;
            this.Balance += Initialize;
        }
        public virtual void Deposit(double money)
        {
            if(money > 0)
            {
                Balance = Initialize + money;
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
            else if (money < 0)
            {
                Console.WriteLine("So tien du khong hop le");
            }
            else if(Balance - money < 0)
            {
                Console.WriteLine("So du tai khong dap ung yeu cau rut cua ban");
            }else if(money < 0){
                Console.WriteLine("So tien du khong hop le");
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
        public SavingAccount(double Initialize, double rate)
            :base(Initialize)
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
        protected double FeeTranfer;
        public CheckAccount(double Balance,double FeeTranFer)
           :base(Balance) 
        {
            this.FeeTranfer = FeeTranFer;   
        }
        public override void Deposit(double money)
        {
            base.Deposit(money);
            if(money > 0)
            {
                Balance -= FeeTranfer;
                Console.WriteLine($"Ban da bi tru {FeeTranfer} tien phi,So du hien tai cua ban la {Balance}");
            }
        }
        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            if(money > 0)
            {
                Balance -= FeeTranfer;
                Console.WriteLine($"Ban da bi tru {FeeTranfer} tien phi,So du hien tai cua ban la {Balance}");
            }
        }
        public new double GetBalance()
        {
            Balance -= FeeTranfer;
            Console.WriteLine($"Ban da bi tru {FeeTranfer} tien phi,So du hien tai cua ban la {Balance}");
            return Balance;
        }
    }
}
