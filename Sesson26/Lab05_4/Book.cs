using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_4
{
    public class Book
    {
        // Khai báo trường
        private string name;

        //  Khai báo mảng chương 
        private Chapter[] chapters;

        // Constructor không tham số
        public Book()
        {

        }

        // Constructor có tham số, là số chương
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapter[n];
        }

        // Định nghĩa thuộc tính
        public string Name
        {
            get { return name; }
            set 
            {
                if (value == null) 
                    throw new ArgumentNullException("value");
                name = value;
            }
        }

        // Index thứ nhất có một tham số kiểu int
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1)
                    return null;
                return chapters[index];
            }
            set
            {
                if (index < 0 || index > chapters.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                chapters[index] = value;
            }
        }

        // Index thứ hai có một tham số kiểu string overload indexer
        public Chapter this[string name]
        {
            get
            {
                foreach (Chapter ch in chapters)
                {
                    if (ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
