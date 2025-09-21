namespace Basic.Models
{
    //String.Empty anlamı string ifadem var ama içi boş anlmaında kullanılır.
    //Null olsaydı bu hiçbir veri yok anlamına gelirdi.
    public class App
    {
        public int id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName} {LastName}";
        public int Age { get; set; } = 0;
        public String Departmant { get; set; } = String.Empty;
    }
}
