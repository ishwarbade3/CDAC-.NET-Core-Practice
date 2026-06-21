using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Shipper
{
    [Key]
    public int shipperId { get; set; }
    public int SupplierId {  get; set; }

    public Supplier Supplier { get; set; }
}
