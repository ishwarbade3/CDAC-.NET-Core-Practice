using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }
    public int CartId {  get; set; }

    public Cart Cart { get; set; }
}
