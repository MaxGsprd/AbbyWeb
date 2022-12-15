using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Display(Name="Display order")]
        [Range(1,100,ErrorMessage ="Display number is out of range 1-100")]
        public int DisplayOrder { get; set; }
    }
}
