using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_1
{
    public class Book
    {
        private int id;
        private string title;
        private int price;
        private string publisher;
        public Book()
        {
        }
        public Book(int id,string title,int price,string publisher)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.publisher = publisher;
        }
        public int Id { get { return id; } }
        public string Title { get { return title; } }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public override string ToString()
        {
            return "id: "+id+" \nTieu De: "+title+" \ngia: "+price+" \nNha phat hanh: "+publisher ;
        }
    }
}
