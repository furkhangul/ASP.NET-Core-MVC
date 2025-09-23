using System.ComponentModel.DataAnnotations;

namespace Basic.Models

{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is required")]
        public String Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "First name is required")]
        public String FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public String LastName { get; set; } = string.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; } = 0;
        public String SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate(){
            ApplyAt = DateTime.Now;
        }
    }
}
