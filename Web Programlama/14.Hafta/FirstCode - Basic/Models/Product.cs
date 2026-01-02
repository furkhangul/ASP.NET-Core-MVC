using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Type { get; set; }
    }
}
