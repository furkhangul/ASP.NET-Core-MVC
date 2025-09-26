using System.ComponentModel.DataAnnotations;

namespace Basic.Models;

public class Data
{
    [Required(ErrorMessage = "Email is required")]
    public String Email { get; set; } = String.Empty;

    [Required(ErrorMessage = "First name is required")]
    public String FirstName { get; set; } = String.Empty;

    [Required(ErrorMessage = "Last name is required")]
    public String LastName { get; set; } = String.Empty;
    public String FullName => $"{FirstName} {LastName.ToUpper()}";
    
    [Required(ErrorMessage = "Username is required")]
    public String Username { get; set; } = String.Empty;

    [Required(ErrorMessage = "Password is required")]
    public String Password { get; set; } = String.Empty;

    public DateTime RegisterTime { get; set; }

    public Data()
    {
        this.RegisterTime = DateTime.Now;
    }    

}
