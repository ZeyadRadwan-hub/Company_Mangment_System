using System.ComponentModel.DataAnnotations;

namespace CompanyMangmentSystem.DTOs
{
    public class DepartmentResponeDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
    }
}
