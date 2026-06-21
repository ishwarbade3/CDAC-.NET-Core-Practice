using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required(ErrorMessage ="Customer name Always Required!!!")]
    [MaxLength(30,ErrorMessage ="maximim length is 30")]
    public string CustomerName { get; set; }

    [Required(ErrorMessage = "Customer name Always Required!!!")]
    [MaxLength(30, ErrorMessage = "maximim length is 30")]
    public string CustomerCity { get; set; }

    public ICollection<Cart> Cart { get; set; } = new List<Cart>();

    
}
