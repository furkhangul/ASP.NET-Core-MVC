using Microsoft.AspNetCore.Mvc;

namespace Deneme.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        public Urun()
        {
        }

        public Urun(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}