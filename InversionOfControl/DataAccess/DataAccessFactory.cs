using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.DataAccess
{
    public static class DataAccessFactory
    {
        //This class is responsible for creating and returning an instance of the EmployeeDataAccess class

        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
