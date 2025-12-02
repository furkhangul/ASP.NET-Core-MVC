using Microsoft.AspNetCore.Mvc;

namespace Basic.Models
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Data(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
        public Data()
        {
        }
    }
}
