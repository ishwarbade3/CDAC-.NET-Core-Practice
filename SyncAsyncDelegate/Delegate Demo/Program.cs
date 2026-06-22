namespace Delegate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delege Example By Ghost!!!!");
            Logger logger = new Logger(WhatsAppLogger);
            logger += EmailLogger;
            if (DateTime.Now.Hour> 12)
            {
                Logger-=WhatsAppLogger;
            }
            logger();









        }
        private static void WhatsAppLogger()
        {
            Console.WriteLine("This Is Whats App Logger !!1");
        }
        private static void EmailLogger()
        {
            Console.WriteLine("This Is Email Logger !!1");
        }
        private static void SmsLogger()
        {
            Console.WriteLine("This Is SMS  Logger !!1");
        }
    }
}
