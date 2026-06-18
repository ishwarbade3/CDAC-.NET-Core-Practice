namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Year :");
                int yr = Convert.ToInt32(Console.ReadLine());
                if(yr % 4 == 0 || yr % 400 == 0&&yr %100 !=0)
                {
                        Console.WriteLine($" Year {yr} is Leap Year");
                }
                else
                {
                    Console.WriteLine($" Year {yr} is Not Leap Year");
                }
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("********** Enter Valid Year!!!!!*******\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
