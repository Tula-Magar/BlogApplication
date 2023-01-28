using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApplication.Models
{
    public class BlogPost
    {

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Modified")]
        public DateTime DateModified { get; set; }

        public string Author { get; set; }

        [DisplayName("Category Type")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }


    }
}
