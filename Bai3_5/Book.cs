using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_5
{
    class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        public int currentPage;

        public Book()
        {
            currentPage = 1;
        }
        public Book(string author,int pages,string isbn,string title,int currentPage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = currentPage;
        }
        public void FlipPageForward()
        {
            if(currentPage < pages)
            {
                currentPage++;
            }
        }
        public void FlipPageBackward()
        {
           if(currentPage > 1)
            {
                currentPage--;
            }
        }
        public void Display()
        {
            Console.WriteLine("Tac gia: " + author);
            Console.WriteLine("So trang: " + pages);
            Console.WriteLine("Ma tieu chuan quoc te: " + isbn);
            Console.WriteLine("Tieu de: " + title);
            Console.WriteLine("Trang hien tai: " + currentPage);
        }
    }
}
