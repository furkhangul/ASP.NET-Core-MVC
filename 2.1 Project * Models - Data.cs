namespace Basic.Models
{
    public class Data
    {
        public int Id { get; set; }
        public String Username { get; set; } = String.Empty;
        public String Email { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;

        public Data()
        {

        }
        public Data(int id, string username, string email, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
    }
}
