namespace Lab04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo lớp windows
            Window win = new Window(1, 2);

            // Khởi tạo lớp listbox
            ListBox lb = new ListBox(3, 4, "Stand alone list box");

            // Khởi tạo lớp button
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();

            // Khởi tạo mảng windows
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}
