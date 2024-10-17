using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    internal class ListBox:Window
    {
        // Khai báo trường mới
        private string listBoxContents;

        // Phương thức khởi tạo
        public ListBox(int top, int left, string contents) : base(top, left) // Gọi constructor lớp cơ sở
        {
            listBoxContents = contents;
        }

        // Ghi đè phương thức DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow(); // Gọi phương thức lớp cơ sở
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }
    }
}
