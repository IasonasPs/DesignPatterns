using DependencyInversion.DataAccess.Interfaces;
using DependencyInversion.Entities;
using InversionOfControl.ProgramHelpers;


namespace DependencyInversion.DataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
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
