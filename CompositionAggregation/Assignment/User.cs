namespace Assignment;

internal class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string email { get; set; }

    public Address address { get; set; } = new Address();

    public long phone { get; set; }
    public string website { get; set; }
    public Company company { get; set; }

    public override string? ToString()
    {
        return Id+" "+Name + " " +email + " " +address + " " +phone + " " +website + " " +company;
    }
    




}
