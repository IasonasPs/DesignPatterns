using DependencyInversion.Entities;

namespace DependencyInversion.DataAccess.Interfaces
{
    public interface IEmployeeDataAccess
    {
        Employee? GetEmployeeDetails(int id);
    }
}
