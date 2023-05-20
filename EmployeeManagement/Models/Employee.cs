using EmployeeManagement.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        [MinLength(3)]
        [MaxLength(20,ErrorMessage = "Max length is 20")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="enter valid email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Departement")]
        public Department? departement { get; set; }
        public string photoPath { get; set; }
    }
}
