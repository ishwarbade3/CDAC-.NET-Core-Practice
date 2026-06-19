namespace ListDemo;

internal class Customer
{
    public int id {  get; set; }
    public string name { get; set; }
    public string city { get; set; }

    public override string? ToString()
    {
        return id +" "+name+" "+city;
    }
}
