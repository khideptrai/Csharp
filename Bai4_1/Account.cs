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
}
