using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Domain.Models
{
    [Table("Authors")] 
    public class Author
    {
        [Key] 
        public int AuthorID { get; set; }

        [Required] 
        [MaxLength(100)] 
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}