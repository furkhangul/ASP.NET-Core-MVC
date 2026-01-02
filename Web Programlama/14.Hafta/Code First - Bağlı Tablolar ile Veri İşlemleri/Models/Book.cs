using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required, MaxLength(100)]
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public decimal BookPrice { get; set; }
        public int AuthorId { get; set; }
        public Author  Author { get; set; }
    }
}
