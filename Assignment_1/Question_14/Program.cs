namespace Question_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Number :");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Absolute number is : {Math.Abs(n)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
