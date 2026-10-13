using CompanyMangmentSystem.Data;
using CompanyMangmentSystem.Models;
using CompanyMangmentSystem.Repo.Contract;

namespace CompanyMangmentSystem.UnitOfWork
{
    public class UnitOfWorkIMP:IUnitOfWork
    {
        private readonly App_Database_Context _db;
        public IGenericRepo<Project> ProjectUnit { get; }
        public IGenericRepo<Employee> EmployeeUnit { get; }
        public IGenericRepo<EmployeeProject> EmployeeProjectUnit { get; }
        public IGenericRepo<Department> DepartmentUnit { get; }

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        public UnitOfWorkIMP(App_Database_Context db, IGenericRepo<Project> projectUnit, IGenericRepo<Employee> employeeUnit, IGenericRepo<EmployeeProject> employeeProjectUnit, IGenericRepo<Department> departmentUnit)
        {
            _db = db;
            ProjectUnit = projectUnit;
            EmployeeUnit = employeeUnit;
            EmployeeProjectUnit = employeeProjectUnit;
            DepartmentUnit = departmentUnit;
        }
    }
}