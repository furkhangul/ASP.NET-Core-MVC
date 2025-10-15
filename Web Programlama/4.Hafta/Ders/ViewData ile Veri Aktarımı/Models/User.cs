namespace Basic.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String UserName { get; set; } = String.Empty;
        public String UserEmail { get; set; } = String.Empty;
        public String UserPassword{ get; set; } = String.Empty;
    }
}