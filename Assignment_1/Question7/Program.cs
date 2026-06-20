namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Employee name :");
                string? name = Console.ReadLine();
                Console.Write("Enter the Basic Salary :");
                double BS = Convert.ToDouble(Console.ReadLine());
                double HRA = BS * 0.20;
                double DA = BS * 0.40;
                double GS = BS + HRA + DA;
                double PF = GS * 0.10;
                double NS = GS - PF;
                Console.WriteLine($"Net Salary of {name} is {NS}");
            }
            catch(FormatException e) {
                Console.WriteLine("********** Enter Valid Detail!!!!!*******\n" +e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

