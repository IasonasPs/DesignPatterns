using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InversionOfControl.Entities;
using InversionOfControl.ProgramHelpers;

namespace InversionOfControl.DataAccess
{
    public class EmployeeDataAccess
    {
        public Employee? GetEmployeeDetails(int id)
        {
            var digits = ConvertIntToIntArray.GetDigits(id);

            if (digits.Count() == 6)
            {
                Employee employee = new Employee()
                {
                    Id = digits[0],
                    Name = $"number{digits[1]}{digits[2]}",
                    Department = $"{digits[3]}{digits[4]}{digits[5]}",
                };
                return employee;
            }
            return null;
        }
    }
}
