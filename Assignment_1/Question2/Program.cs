
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Student Name : ");
                string? name = Console.ReadLine();
                Console.Write("Enter Marks of 1 Subject :");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of 2 Subject :");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of 3 Subject :");
                int m3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of 4 Subject :");
                int m4 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks of 5 Subject :");
                int m5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Average of \"{name}\" Marks Of All 5 subject is : {(m1 + m2 + m3 + m4 + m5) / 5}");
            }
            catch (FormatException f)
            {
                Console.WriteLine("Invalid input Enter Valif input!!!!!");
            }
            catch (Exception  e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
