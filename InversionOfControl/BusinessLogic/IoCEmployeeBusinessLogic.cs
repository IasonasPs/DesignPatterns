using InversionOfControl.DataAccess;
using InversionOfControl.Entities;

namespace InversionOfControl.BusinessLogic
{
    internal class IoCEmployeeBusinessLogic
    {
        readonly EmployeeDataAccess _employeeDataAccess;

        public IoCEmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee? GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }

    }
}
