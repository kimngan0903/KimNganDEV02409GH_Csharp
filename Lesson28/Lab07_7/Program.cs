

namespace Lab07_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Student st = new Student();

            Console.Write("Nhập ID: {0}", st.id);
            st.id = (Console.ReadLine());

            Console.Write("Nhập Name: {0}", st.name);
            st.name = (Console.ReadLine());

            Console.Write("Nhập điểm lý thuyết: {0}", st.theorymark);
            st.theorymark = Convert.ToByte(Console.ReadLine());

            Console.Write("Nhập điểm thực hành: {0}", st.labmark);
            st.labmark = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (st.theorymark < 0 || st.theorymark > 10)
                {
                    throw new InvalidMarkException("Invalid mark value: " + st.theorymark);
                }
            }
            catch (InvalidMarkException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                if (st.labmark < 0 || st.labmark > 10)
                {
                    throw new InvalidMarkException("Invalid mark value: " + st.labmark);
                }
            }
            catch (InvalidMarkException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
