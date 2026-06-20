namespace FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Demo Code!!!!");
            string filePath = "test.txt";
            string cFilePath = "cTest.txt";
            string mFilePath = "mTest.txt";

            File.WriteAllText(filePath, "Hi Ishwar How Are You!!!");

            if (File.Exists(filePath))
            {
                Console.WriteLine("Given path File is Exist!!!");
            }
            string msg = File.ReadAllText(filePath);
            Console.WriteLine($"Content read from file is :\"{msg}\"");

            string[] str = File.ReadAllLines(filePath);
            Console.WriteLine("All the lines from file as Follow!!!");
            foreach (string str1 in str)
            {
                Console.WriteLine(str1);
                                }
            File.Copy(filePath, cFilePath, true);
            Console.WriteLine("File Copied Sucessfully!!!");
            string msg1 = File.ReadAllText(cFilePath);
            Console.WriteLine($"Content read from Copy File is :\"{msg}\"");

            File.Move(filePath, mFilePath);
            Console.WriteLine("File Moved Sucessfully!!!");
            string msg2 = File.ReadAllText(mFilePath);
            Console.WriteLine($"Content read from Moved File is :\"{msg}\"");
            File.Delete(filePath);
            Console.WriteLine("file Deleted SucessFully !!!");
          

        }
    }
}
