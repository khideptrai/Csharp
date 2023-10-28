using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_4
{
    class Person
    {
        private string name;
        private int phone;
        private string email;

        public override string ToString()
        {
            return "Class Name: "+GetType() +" Name: "+ Name +" Email: "+ Email;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
