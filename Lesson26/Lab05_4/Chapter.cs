using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_4
{
    public class Chapter
    {
        private string name;
        private string content;

        // Constructor không tham số
        public Chapter()
        {
            name = "";
            content = "";
        }

        // Constructor có tham số
        public Chapter(string name, string content)
        {
            this.name = name;
            this.content = content;
        }

        // Định nghĩa các thuộc tính
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        // Ghi đè phương thức tostring
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
