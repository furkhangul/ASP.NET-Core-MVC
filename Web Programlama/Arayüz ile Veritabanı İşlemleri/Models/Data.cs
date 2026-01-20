using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurOfTheWeak.Models
{
    public class Data
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
