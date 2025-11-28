using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class DataMetaData
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }
        [Length(4,18,ErrorMessage = "Geçerli Uzunluk Giriniz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Password { get; set; }
    }
}
