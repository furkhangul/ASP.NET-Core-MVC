namespace Hafta6.Models;
public class Data
{
    public String Email { get; set; } = String.Empty;
    public String Username { get; set; } = String.Empty;
    public String Password { get; set; } = String.Empty;

    public Data()
    {

    }
    public Data(string email, string username, string password)
    {
        this.Email = email;
        this.Username = username;
        this.Password = password;
    }
}

