namespace Hafta3.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; } = String.Empty;
        public double Fiyat { get; set; }


        public Urun()
        {
            
        }
        public Urun(int id, string ad, double fiyat)
        {
            this.Id = id;
            this.Ad = ad;
            this.Fiyat = fiyat;
        }
    }
}
