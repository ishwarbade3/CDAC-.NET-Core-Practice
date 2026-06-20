namespace Question_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Date in format (dd/mm/yy");
            //DateTime dt = Convert.ToDateTime(Console.ReadLine);

            //Console.WriteLine($"Month : ");

            try
            {
                Console.Write("Enter date (dd/mm/yy): ");
                string date = Console.ReadLine();

                string[] parts = date.Trim().Split('/');

                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int year = 2000 + int.Parse(parts[2]);

                string monthName = "";
                int days = 0;

                switch (month)
                {
                    case 1:
                        monthName = "January";
                        days = 31;
                        break;
                    case 2:
                        monthName = "February";
                        days = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? 29 : 28;
                        break;
                    case 3:
                        monthName = "March";
                        days = 31;
                        break;
                    case 4:
                        monthName = "April";
                        days = 30;
                        break;
                    case 5:
                        monthName = "May";
                        days = 31;
                        break;
                    case 6:
                        monthName = "June";
                        days = 30;
                        break;
                    case 7:
                        monthName = "July";
                        days = 31;
                        break;
                    case 8:
                        monthName = "August";
                        days = 31;
                        break;
                    case 9:
                        monthName = "September";
                        days = 30;
                        break;
                    case 10:
                        monthName = "October";
                        days = 31;
                        break;
                    case 11:
                        monthName = "November";
                        days = 30;
                        break;
                    case 12:
                        monthName = "December";
                        days = 31;
                        break;
                    default:
                        Console.WriteLine("Invalid month!");
                        return;
                }

                Console.WriteLine("Month: " + monthName);
                Console.WriteLine("Number of days: " + days);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Enter valid date!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
