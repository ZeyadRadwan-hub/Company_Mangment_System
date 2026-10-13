using System.ComponentModel.DataAnnotations;

namespace CompanyMangmentSystem.DTOs
{
    public class ProjectResponeDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required, Range(1000, 1000000)]
        public int Budget { get; set; }
    }
}
