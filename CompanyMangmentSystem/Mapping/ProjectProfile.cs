using AutoMapper;
using CompanyMangmentSystem.DTOs;
using CompanyMangmentSystem.Models;

namespace CompanyMangmentSystem.Mapping
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile() 
        {
            CreateMap<Project,ProjectResponeDTO>().ReverseMap();
            CreateMap<Project,ProjectDTO>().ReverseMap();
        }
    }
}
