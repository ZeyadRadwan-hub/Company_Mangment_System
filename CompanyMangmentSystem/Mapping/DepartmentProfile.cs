using AutoMapper;
using CompanyMangmentSystem.DTOs;
using CompanyMangmentSystem.Models;

namespace CompanyMangmentSystem.Mapping
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile() 
        {
            CreateMap<Department,DepartmentResponeDTO>().ReverseMap();
            CreateMap<Department,DepartmentDTO>().ReverseMap();
        }
    }
}
