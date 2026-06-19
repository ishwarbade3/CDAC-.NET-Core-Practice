namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Demo !!!!");
            Queue<Employee> queue = new Queue<Employee>();

            queue.Enqueue(new Employee()
            {
                id = 1011,
                name = "Sai",
                salary = 36750
            });
            queue.Enqueue(new Employee()
            {
                id = 1111,
                name = "Sidd",
                salary = 62650
            });
            queue.Enqueue(new Employee()
            {
                id = 1012,
                name = "Adi",
                salary = 26565
            });
            queue.Enqueue(new Employee()
            {
                id = 1013,
                name = "Rohit",
                salary = 32568
            });

            foreach (Employee e in queue)
            {
                Console.WriteLine(e);
            }

        }
    }
}
