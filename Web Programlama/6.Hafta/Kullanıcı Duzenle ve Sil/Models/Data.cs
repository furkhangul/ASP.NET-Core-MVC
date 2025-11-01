namespace Hafta6.Models;
public class Data
{
    public int Id{ get; set; }
    public String Email { get; set; } = String.Empty;
    public String Username { get; set; } = String.Empty;
    public String Password { get; set; } = String.Empty;

    public Data()
    {

    }
    public Data(int id, String email, String username, String password)
    {
        this.Id = id;
        this.Email = email;
        this.Username = username;
        this.Password = password;
    }
}

