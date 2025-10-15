namespace Basic.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String UserName { get; set; } = String.Empty;
        public String UserEmail { get; set; } = String.Empty;
        public String UserPassword { get; set; } = String.Empty;
        public User()
        {

        }
        public User(int id, string name, string email, string password)
        {
            UserId = id;
            UserName = name;
            UserEmail = email;
            UserPassword = password;
        } 
    }
}