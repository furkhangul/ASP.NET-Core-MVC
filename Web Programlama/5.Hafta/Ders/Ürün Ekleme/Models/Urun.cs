using Microsoft.AspNetCore.Mvc;

namespace Basic.Models;

public class UrunView
{
    public int ID { get; set; }
    public String Name { get; set; } = String.Empty;
    public String Description { get; set; } = String.Empty;
    public Double Price { get; set; }
    public bool Stock { get; set; }


    public UrunView()
    {
        
    }
    public UrunView(int id, string name, string description, double price, bool stock)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Stock = stock;
    }
}
