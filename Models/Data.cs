using System.ComponentModel.DataAnnotations;

namespace FurOfTheWeak.Models {

   
    public class Data
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz !")]
        public String Username { get; set; } = String.Empty;
        public String Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz !")]
        [Length(2,15,ErrorMessage ="Şifreniz 2 ile 15 karakter içermesi gerekmektedir !")]
        public String Password { get; set; } = String.Empty;

        public Data()
        {

        }

        public Data(int id, string username, string email, string password)
        {
            this.ID = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
    }
}
