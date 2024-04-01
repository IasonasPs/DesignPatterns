using InversionOfControl.BusinessLogic;
using InversionOfControl.Entities;

namespace InversionOfControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

            IoCEmployeeBusinessLogic employeeBusinessLogic = new IoCEmployeeBusinessLogic();
            
            
            Employee? emp = employeeBusinessLogic.GetEmployeeDetails(105623);

            Console.WriteLine($"{emp.Id} , {emp.Name} , {emp.Department} ");
            Console.ReadKey();

        }
    }
}
