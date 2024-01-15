using InversionOfControl.DataAccess;
using InversionOfControl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.BusinessLogic
{
    public class EmployeeBusinessLogic
    {
        public readonly EmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = new EmployeeDataAccess();
        }
        public Employee? GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}