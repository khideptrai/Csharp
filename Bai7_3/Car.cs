using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_3
{
    internal class Car
    {
        public string Name { get; set; }
        public string Color {  get; set; }
        public override string ToString()
        {
            return "Name: "+Name+" Color: "+Color;
        }
    }
}
