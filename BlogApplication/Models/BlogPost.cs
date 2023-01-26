using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        
        
    }
}
