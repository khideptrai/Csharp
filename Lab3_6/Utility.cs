using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_6
{
    class Utility
    {
        public void SwapFake(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void SwapReally(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void AreaCircle(double redius,out double area)
        {
            area = 2 * Math.PI * redius;
        }
    }
}
