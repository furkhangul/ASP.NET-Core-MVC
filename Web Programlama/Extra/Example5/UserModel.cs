namespace Basic.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public UserModel()
        {

        }
        public UserModel(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
