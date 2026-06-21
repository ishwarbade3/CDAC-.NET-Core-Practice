using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    public ICollection<Shipper> shippers { get; set; }
}
