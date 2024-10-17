namespace Lab04_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Document document = new Document();
            // Gán nội dung cho document
            document.content = "Đây là nội dung của document";

            // Ghi vào file
            string filePath = "document.txt";
            document.Write(filePath);
            
            // Đọc lại từ file
            document.Read(filePath);
            Console.WriteLine($"Nội dung tài liệu: {document.content}");

            // Mã hóa nội dung
            string encryptedContent = document.Encrypt();
            Console.WriteLine($"Mã hóa nội dung: {encryptedContent}");

            // Gán dữ liệu đã mã hóa cho document để thử giải mã
            document.content = encryptedContent;
            string decryptedContent = document.Decrypt();
            Console.WriteLine($"Decrypted nội dung: {decryptedContent}");
        }
    }
}
