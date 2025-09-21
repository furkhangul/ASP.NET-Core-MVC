namespace Basic.Models
{
    public class Candidate
    {
        public String email { get; set; } = string.Empty;
        public String FirstName { get; set; } = string.Empty;
        public String LastName { get; set; } = string.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; } = 0;
        public String SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate(){
            ApplyAt = DateTime.Now;
        }
    }
}
