using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Car
    {
        // khai bao cac truong voi pham vi public
        public string make;
        public string model;
        public string color;
        public int year;
        // dinh nghia phuong thuc start
        public void Start()
        {
            System.Console.WriteLine(model + " khoi dong");
        }
        public void Stop()
        {
            System.Console.WriteLine(model + " dung");
        }
    }
}
