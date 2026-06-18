using System.Diagnostics;

namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the First Number :");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Sign of Calculation :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter the Second Number :");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (ch)
                {

                    case '+':
                        Console.WriteLine($"Addition : {(num1 + num2)}");
                        break;
                    case '-':
                        Console.WriteLine($"Substration : {(num1 - num2)}");
                        break;
                    case '*':
                        Console.WriteLine($"Multiplication : {(num1 * num2)}");
                        break;
                    case '/':
                        Console.WriteLine($"Division : {(num1 / num2)}");
                        break;

                    default:
                        Console.WriteLine("Enter the valid Values!!!!");
                        break;
                }
            }
            catch(ArithmeticException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            }
        }
    }

