using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [DisplayName("Category Name")]
        [Required(ErrorMessage ="Category Name field is Always Required")]
        [MaxLength(100,ErrorMessage ="Maximum only 100 Charecter is Allowed in field")]
        public string CategoryName { get; set; }
        [DisplayName("Category Description")]
        [Required(ErrorMessage ="Category Description Field is Always Required")]
        [MaxLength(200,ErrorMessage ="Maximum only 200 Charecter is Allowed in field")]
        public string CategoryDescription { get; set; }

        public ICollection<Product> products { get; set; }

    }
}
