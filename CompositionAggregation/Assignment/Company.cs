namespace Assignment;

internal class Company
{
    public string name { get; set; }

    public string catchPhrase { get; set; }
    public string bs { get; set; }

    public override string? ToString()
    {
        return name+" "+catchPhrase+" "+bs;
    }
}