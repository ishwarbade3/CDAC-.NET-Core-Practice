namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Demo ");
            Stack<Book> st = new Stack<Book>();
            Book b1 = new Book();
            b1.Id = 3255;
            b1.title = "Java";
            b1.auther = "G. Jawsel";
            b1.price = 2356;

            Book b2 = new Book();
            b2.Id = 3256;
            b2.title = "C# Programming";
            b2.auther = "Andrew Troelsen";
            b2.price = 1999;

            Book b3 = new Book();
            b3.Id = 3257;
            b3.title = "Python Basics";
            b3.auther = "Eric Matthes";
            b3.price = 1499;

            Book b4 = new Book();
            b4.Id = 3258;
            b4.title = "Data Structures";
            b4.auther = "Seymour Lipschutz";
            b4.price = 1750;

            Book b5 = new Book();
            b5.Id = 3259;
            b5.title = "Operating Systems";
            b5.auther = "Abraham Silberschatz";
            b5.price = 2250;
            st.Push(b1);
            st.Push(b2);
            st.Push(b3);
            st.Push(b4);
            st.Push(b5);
             foreach (Book book in st)
            {
                Console.WriteLine(book);
            }

        }


        }
}
