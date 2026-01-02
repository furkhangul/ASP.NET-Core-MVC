using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        [Required, MaxLength(100)]
        public string AuthorName { get; set; }
        [Required, Range(0, 100)]
        public int Age { get; set; }
        [Required, MaxLength(1000)]
        public string AuthorBio { get; set; }
        public List<Book> Books { get; set; }
    }
}
