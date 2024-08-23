using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Oder")]
        [Range(1,100, ErrorMessage ="Dispaly order must Be between 1-100")]
        public int DisplayOrder { get; set; }
    
    }
}
