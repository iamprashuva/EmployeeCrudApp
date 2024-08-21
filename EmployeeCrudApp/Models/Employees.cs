using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudApp.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Enter your address")]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Select your gender")]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Enter your Job Title")]
        [Display(Name = "Job Title")]
        [StringLength(200)]
        public string? JobTitle { get; set; }
        public DateTime HireDate {  get; set; }
    }
}
