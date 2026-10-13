using CompanyMangmentSystem.Models;
using CompanyMangmentSystem.Repo.Contract;

namespace CompanyMangmentSystem.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepo<Project> ProjectUnit { get; }
        IGenericRepo<Employee> EmployeeUnit { get; }
        IGenericRepo<EmployeeProject> EmployeeProjectUnit { get; }
        IGenericRepo<Department> DepartmentUnit { get; }
        Task<int> SaveAsync();

    }
}
