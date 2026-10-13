using System.ComponentModel.DataAnnotations;

namespace CompanyMangmentSystem.DTOs
{
    public class EmployeeProjectDTO
    {
        [Required, MaxLength(50)]
        public string AssignRole { get; set; }
        [Required]
        public DateTime AssignDate { get; set; }
    }
}
