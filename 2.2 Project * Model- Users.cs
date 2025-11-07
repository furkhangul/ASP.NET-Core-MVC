namespace Basic.Models
{
    public class Users
    {
        public int Id { get; set; }
        public String Email { get; set; } = String.Empty;
        public String Username { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;

        public Users()
        {

        }
        
        public Users(int id,string email, string username, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }
    }
        
}
