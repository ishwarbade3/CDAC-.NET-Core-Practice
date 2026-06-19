namespace DictioneryAss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Dictionery demo !!!!");

            Dictionary<int,Employee> list = new Dictionary<int,Employee>();

            list.Add(1, new Employee()
            {Id=1011,
            Name="Sai",
            salary=36750
            });
            list.Add(2, new Employee()
            {
                Id = 1211,
                Name = "levis",
                salary = 72890
            });
            list.Add(3, new Employee()
            {
                Id = 1111,
                Name = "Martin",
                salary = 50263
            });
            list.Add(4, new Employee()
            {
                Id = 1010,
                Name = "Ashish",
                salary = 63500
            });
            list.Add(5, new Employee()
            {
                Id = 1121,
                Name = "Sidd",
                salary = 75360
            });

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}, {item.Value.Id}  {item.Value.Name}  {item.Value.salary}");
            }

        }
    }
}
