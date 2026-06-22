namespace Delegate_Demo;

public delegate void Logger();
internal class Stuudent
{
    public event Logger PuneHiring;
    public event Logger OtherCityHiring;

    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }

   public string GetJobNotification()
    {
        if (City == "Pune")
        {
            if (PuneHiring != null)
            {
                PuneHiring();
            }
            Console.WriteLine("Amazon Is Hiring in pune!!");
            return "Amazon!!!!!";

        }
        else
        {
            if (OtherCityHiring != null)
            {
                OtherCityHiring();
            }
            Console.WriteLine("Other MNCs Are Hiring for Another Location !!");
            return "MNCs !!!";
        }
    }
}
