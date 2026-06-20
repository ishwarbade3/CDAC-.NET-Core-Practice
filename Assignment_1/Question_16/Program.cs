namespace Question_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            for ( i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"Given Number {n} is not a prime number");
                    break;
                }
            }
            if (i == n)
            {
                Console.WriteLine($"Given Number {n} is a prime number");
            }
            int j = 1;
            int count = 0;
            Console.Write("Prime Numbers are : ");
            while (count < 25)
            {
                int flag = 0;
                int k = 2;
                while(k < j)
                {
                    if (j % k == 0)
                    {
                        flag = 1;
                        break;
                    }
                    k++;

                }
                if (flag == 0)
                {
                    Console.Write(" " + j);
                    count++;
                }
                j++;
            }
            count = 0;
            int num = 3;

            Console.Write("\nPrint 25 using Do While loop : 1 2");
            do
            {
                int a = 2;
                int flag = 0;
                do
                {
                    if(num % a == 0)
                    {
                        flag = 1;
                        break;
                    }
                    a++;

                } while (a < num);
                if (flag == 0)
                {
                    Console.Write(" "+num);
                    count++;
                }
                num++;

            }while(count < 23);
        }
    }
}
