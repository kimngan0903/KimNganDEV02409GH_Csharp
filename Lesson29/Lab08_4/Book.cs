using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_4
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }

        public Book(int id, string name, string author, double price, string publisher, int year)
        {
            Id = id;
            Name = name;
            Author = author;
            Price = price;
            Publisher = publisher;
            Year = year;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Author: {Author}, Price: {Price}, Publisher: {Publisher}, Year: {Year}";
        }
    }
}
