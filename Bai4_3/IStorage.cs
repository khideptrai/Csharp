using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_3
{
    interface IStoreage
    {
        Object Data { get; set; }
        void Read(string filename);
        void Write(string filename);
    }
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }
    public class Document : IStoreage, IEncryptable
    {
        public Object Data { get; set; }
        public string Content { get; set; }
        public void Read(string filename)
        {
            Console.WriteLine("Doc du lieu");
        }
        public void Write(string filename)
        {
            Console.WriteLine("Ghi du lieu");
        }
        public void Encrypt()
        {
            Console.WriteLine("Ma hoa du lieu");
        }
        public void Decrypt()
        {
            Console.WriteLine("Giai ma du lieu");
        }
    }
}
