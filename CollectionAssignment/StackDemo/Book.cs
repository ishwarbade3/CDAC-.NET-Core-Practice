namespace StackDemo;

internal class Book
{
   public int Id { get; set; }
    public string title { get; set; }
    public string auther { get; set; }
    public int price { get; set; }

    public override string? ToString()
    {
        return Id+" \""+title+"\" \""+auther+
            "\" "+price;
    }
}
