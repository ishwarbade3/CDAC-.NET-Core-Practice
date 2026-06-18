namespace Question_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 255; i++)
            {
                Console.Write($"  ,{i}:{(char)i}");
            }
        }
    }
}
