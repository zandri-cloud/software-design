using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Domain.Models
{
    [Table("Books")]
    public class Book
    {
        [Key] // Primary Key
        public int BookID { get; set; }

        [Required] 
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [ForeignKey("Author")] 
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
    }
}