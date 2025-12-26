namespace Project.Models
{
    public class Personel
    {
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Departman { get; set; } = string.Empty;
        public Personel(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        public Personel()
        {
        }

    }

}
