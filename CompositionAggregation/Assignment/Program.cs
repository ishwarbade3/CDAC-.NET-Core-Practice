using System.Net;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aggregattion Compomposition Demo!!!!!!");

          

            Company company = new Company() { name="TestCompany" ,catchPhrase="Catch Phrase demo for company",bs="bs demo for company"};
            


            User user = new User() { Id=123,Name="Ghost",email="abs123@gmail.com",phone=1234567895,website="ghost.com",company=company};
            user.address.street = "Shiv Road";
            user.address.suit = "Apt 0445";
            user.address.city = "Pune";
            user.address.zipcode = 141414;
            user.address.geo.Latitude = 294546.26;
            user.address.geo.Longitude = 26589356.256;
            Console.WriteLine("User Becomes :"+user);

        }
    }
}
