﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.DataAccess;
using DependencyInversion.DataAccess.Interfaces;
using DependencyInversion.Entities;

namespace DependencyInversion.BusinessLogic
{
    public class EmployeeBusinessLogic
    {
        readonly IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee? GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
