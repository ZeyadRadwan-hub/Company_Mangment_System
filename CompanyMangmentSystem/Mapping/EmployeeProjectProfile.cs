using AutoMapper;
using CompanyMangmentSystem.DTOs;
using CompanyMangmentSystem.Models;

namespace CompanyMangmentSystem.Mapping
{
    public class EmployeeProjectProfile:Profile
    {
        public EmployeeProjectProfile() 
        {
            CreateMap<EmployeeProject,EmployeeProjectResponeDTO>().ReverseMap();
            CreateMap<EmployeeProject,EmployeeProjectDTO>().ReverseMap();
        }
    }
}
