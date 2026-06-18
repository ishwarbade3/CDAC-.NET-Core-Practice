namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("Enter the Employee Number :");
            int e_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Department Number :");
            int d_N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Designation Character :");
            char d_Code = Convert.ToChar(Console.ReadLine());
                string dept;
                if (d_N == 10)
                {
                    dept = "Purchase";
                }
                else if (d_N == 20)
                {
                    dept = "Sales";
                }
                else if (d_N == 30)
                {
                    dept = "Production";
                }
                else if (d_N == 40)
                {
                    dept = "Marketing";
                }
                else if (d_N == 50)
                {
                    dept = "Accounts";
                }
                else
                {
                    dept = "NA";
                }
                string desig;
                if (d_Code == 'M')
                {
                    desig = "Manager";
                } else if (d_Code == 'S')
                {
                    desig = "Supervisor";
                }
                else if (d_Code == 'A')
                {
                    desig = "Analyst";
                }
                else if (d_Code == 's')
                {
                    desig = "Sales Person";
                }
                else if (d_Code == 'a')
                {
                    desig = "Accountant";
                }else
                {
                    desig = "NA";
                }
                Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                Console.WriteLine($"{e_No}  \t     {d_N}  \t        {dept}     \t       {d_Code}   \t    {desig}   ");







                //switch (d_Code)
                //{

                //    case '+':
                //        Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                //        Console.WriteLine($"   {e_No}       {d_N}           {dept}            {d_Code}        {desig}   ");
                //        break;
                //    case '-':
                //        Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                //        Console.WriteLine($"   {e_No}       { d_N}           {dept}            {d_Code}        {desig}   ");
                //        break;
                //    case '*':
                //        Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                //        Console.WriteLine($"   {e_No}       {d_N}           {dept}            {d_Code}        {desig}   ");
                //        break;
                //    case '/':
                //        Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                //        Console.WriteLine($"   {e_No}       {d_N}           {dept}            {d_Code}        {desig}   ");
                //        break;

                //    default:
                //        Console.WriteLine("Employee no |Department No |Department Name |Designation  Code | Designation | ");
                //        Console.WriteLine($"   {e_No}       {d_N}           {dept}            {d_Code}        {desig}   ");
                //        break;
                //}
            }
            catch (ArithmeticException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (FormatException f)
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
