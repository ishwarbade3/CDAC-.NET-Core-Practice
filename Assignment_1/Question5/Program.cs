namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st Number :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2st Number :");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Number before swapping a = {a} and b= {b}");
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine($"Number after swapping a = {a} and b= {b}");
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.ToString() +"\n*****Enter Valid Values!!!!!! ");
            }
            catch (Exception e)
            {
                Console.WriteLine (e.ToString());
            }
        }
    }
}
