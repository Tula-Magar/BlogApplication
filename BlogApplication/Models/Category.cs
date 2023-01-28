using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  
        
    }
}