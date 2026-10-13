using System.ComponentModel.DataAnnotations;

namespace CompanyMangmentSystem.DTOs
{
    public class DepartmentDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
    }
}
