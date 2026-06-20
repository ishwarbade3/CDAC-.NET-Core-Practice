using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models;

public class Product
{
    [Key]
    public int productId { get; set; }
    [DisplayName("Product Name")]
    [Required(ErrorMessage = "Product Name Field is Always Required")]
    [MaxLength(100, ErrorMessage = "Maximum only 100 Charecter is Allowed in field")]
    public string productName { get; set; }
    [DisplayName("Product Description")]
    [Required(ErrorMessage = "Product Description Field is Always Required")]
    [MaxLength(200, ErrorMessage = "Maximum only 200 Charecter is Allowed in field")]

    public string productDescription { get; set; }
    [Required(ErrorMessage = "Product Price Field is Always Required")]
    public decimal unitPrice { get; set; }
    [Required(ErrorMessage = "Product Quentity Field is Always Required")]
    public int quantity { get; set; }

    public int productCategoryId { get; set; }
    public Category category { get; set; }

   

}
