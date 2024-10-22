using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{
    internal class Book
    {
        // Khai báo các thuộc tính tự động
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Constructor
        public Book(int id, string title, string author, string publisher, int year, double price)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.Price = price;
        }

        // Ghi đè phương thức tostring
        public override string ToString()
        {
            return "\nId: " + Id + "\nTitle: " + Title + "\nAuthor: " + Author + "\nPublisher: " + Publisher + "\nYear: " + Year + "\nPrice: " + Price;
        }
    }
}
