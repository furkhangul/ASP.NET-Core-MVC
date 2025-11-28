using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Basic.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Please enter ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter 'Username' area")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter 'E-Mail' area")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi giriniz !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter 'Password' area")]
        [Length(4, 25, ErrorMessage = "Lütfen 4 ile 16 karakter uzunluğunda şifre giriniz !")]
        public string Password { get; set; }

        public Data(int id, string username, string email, string password)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
        }
        public Data()
        {
            
        }
    }
}
