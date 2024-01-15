using InversionOfControl.DataAccess;
using InversionOfControl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
