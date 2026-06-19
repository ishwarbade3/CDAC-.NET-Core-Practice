namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer list is as Follow !!!!");
            List<Customer> list = new List<Customer>();

            list.Add(new Customer() {id=101,name="Addi",city="pune"});
            list.Add(new Customer() { id = 102, name = "sidd", city = "delhi" });
            list.Add(new Customer() { id = 103, name = "swayam", city = "beed" });
            list.Add(new Customer() { id = 104, name = "ashish", city = "delhi" });
            list.Add(new Customer() { id = 105, name = "sai", city = "beed" });
            list.Add(new Customer() { id = 106, name = "java", city = "pune" });

            foreach (Customer customer in list)
            {
                Console.WriteLine(customer);
            }
            try
            {
                Console.Write("Enter the city Name :");
                string? city = Console.ReadLine();
                foreach (Customer customer in list)
                {
                    if (customer.city == city.ToLower())
                    {
                        Console.WriteLine(customer);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
