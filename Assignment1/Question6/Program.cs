using System.Linq.Expressions;

namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.Write("Enter the Character :");
                char ch = Convert.ToChar((Console.Read()));
                Console.WriteLine($"ASCII value of charecter '{ch}' is :"+Convert.ToInt32(ch));
            }
            catch(FormatException e){
                Console.WriteLine(e.StackTrace + "\n Enter valid Character !!!!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
