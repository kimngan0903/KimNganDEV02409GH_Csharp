namespace Lab07_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InvalidCastException
            try
            {
                object value = "hello";
                int number = (int)value;// sẽ gây ra InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException: " + ex.Message);
            }

            // IndexOutOfRangeException
            try
            {
                int[] numbers = { 1, 2, 3 };
                int value = numbers[10];// sẽ gây ra IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }


            //ArrayTypeMismatchException
            try
            {
                object[] objects = new object[3];
                objects[0] = "hello";
                objects[1] = 123;
                int number = (int)objects[0];// sẽ gây ra ArrayTypeMissMatchException 
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException:" + ex.Message);
            }
        }
    }
}