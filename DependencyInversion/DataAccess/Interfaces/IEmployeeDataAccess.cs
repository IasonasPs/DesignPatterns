using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.Entities;

namespace DependencyInversion.DataAccess.Interfaces
{
    public interface IEmployeeDataAccess
    {
        Employee? GetEmployeeDetails(int id);
    }
}
