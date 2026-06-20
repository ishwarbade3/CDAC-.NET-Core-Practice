namespace Assignment;

internal class Address
{
    public string street { get; set; }
    public string suit { get; set; }
    public string city { get; set; }

    public int zipcode { get; set; }
    public Geo geo { get; set; } =new Geo();



    public Address()
    {
        

    }

    public override string? ToString()
    {
        return street +" "+ suit + " " +city + " " +zipcode + " " +geo ;
    }
}

