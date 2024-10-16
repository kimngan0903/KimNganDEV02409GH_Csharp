using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_6
{
    internal class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int curentpage;

        public Book() 
        {
            author = "";
            pages = 0;
            isbn = "";
            title = "";
            curentpage = 1;
        }

        public Book(string author, int pages, string isbn, string title, int curentpage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.curentpage = curentpage;
        }

        public void Display()
        {
            Console.WriteLine("Tác giả: " + author);
            Console.WriteLine("Trang: " + pages);
            Console.WriteLine("Isbn: " + isbn);
            Console.WriteLine("Tiêu đề: " + title);
            Console.WriteLine("Trang hiện tại: " + curentpage);
        }

        public void flipPageForWard()
        {
            if (curentpage < pages)
            {
                curentpage++;
            }
            else {
                Console.WriteLine("Bạn đang ở trang cuối cùng, không thể lật tiếp.");
            }
        }

        public void flipPageBackWard()
        {
            if (curentpage > 1)
            {
                curentpage--;
            }
            else
            {
                Console.WriteLine("Bạn đang ở trang đầu tiên, không thể lật về sau.");
            }
        }
    }
}
