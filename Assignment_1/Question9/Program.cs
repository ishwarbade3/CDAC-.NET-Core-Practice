namespace Question9
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
                Console.Write("Enter the Total sales :");
                double sales = Convert.ToDouble(Console.ReadLine());
                double commission;
                if (sales >= 5000 && sales <= 7500)
                {
                    commission = sales * 0.03;
                }
                else if (sales >= 7501 && sales <= 10500)
                {
                    commission = sales * 0.08;
                }
                else if (sales >= 10501 && sales <= 15000)
                {
                    commission = sales * 0.11;
                }
                else if (sales >= 15001)
                {
                    commission = sales * 0.15;
                }
                else
                {
                    commission = 0;
                }
                Console.WriteLine($"Net Salary of {name} is : {BS + commission}");
                Console.WriteLine($"Total Commision  of {name} is : {commission}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("********** Enter Valid Detail!!!!!*******\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}



