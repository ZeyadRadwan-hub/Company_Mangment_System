using System.ComponentModel.DataAnnotations;

namespace CompanyMangmentSystem.DTOs
{
    public class EmployeeProjectResponeDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string AssignRole { get; set; }
        [Required]
        public DateTime AssignDate { get; set; }
    }
}
