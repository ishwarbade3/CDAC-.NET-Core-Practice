using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Cart
{
    [Key]
    public int CartId { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer{ get; set; }

    public ICollection<CartItem> CartItems { get; set; }=new List<CartItem>();
    public ICollection<Invoice> Invoices { get; set; }= new List<Invoice>();
}
