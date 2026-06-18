namespace Question_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the First Number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number :");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Third Number :");
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                    Console.WriteLine("Maximum is : " + num1);
                else if (num2 > num1 && num2 > num3)
                    Console.WriteLine("Maximum is : " + num2);
                else
                    Console.WriteLine("Maximum is :" + num3);

                Console.WriteLine($"Maximum Number from \"{num1}\" \"{num2}\" \"{num3}\" is : {((num1 > num2 && num1 > num3) ? (num1) : ((num2 > num3 && num2 > num1)) ? num2 : num3)}");

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
