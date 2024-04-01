using DependencyInversion.DataAccess.Interfaces;

namespace DependencyInversion.DataAccess
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
