using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        public string? CategoryName { get; set; }
    }
}