using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    [DisplayName("Product Name")]
    [Required(ErrorMessage = "Product Name Field is Always Required")]
    [MaxLength(100, ErrorMessage = "Maximum only 100 Charecter is Allowed in field")]
    public string ProductName { get; set; }
    [DisplayName("Product Description")]
    [Required(ErrorMessage = "Product Description Field is Always Required")]
    [MaxLength(200, ErrorMessage = "Maximum only 200 Charecter is Allowed in field")]

    public string ProductDescription { get; set; }
    [Required(ErrorMessage = "Product Price Field is Always Required")]
    public decimal UnitPrice { get; set; }
    [Required(ErrorMessage = "Product Quentity Field is Always Required")]
    public int Quantity { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

   

}
