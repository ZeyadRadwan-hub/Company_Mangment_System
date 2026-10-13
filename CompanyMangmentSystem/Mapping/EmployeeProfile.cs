using AutoMapper;
using CompanyMangmentSystem.DTOs;
using CompanyMangmentSystem.Models;

namespace CompanyMangmentSystem.Mapping
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        { 
            CreateMap<Employee,EmployeeProjectDTO>().ReverseMap();
            CreateMap<Employee,EmployeeDTO>().ReverseMap();
        }
    }
}
