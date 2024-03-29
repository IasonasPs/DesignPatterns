﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._2nd
{
    internal class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
            => reports.Where(r => r.Level == DeveloperLevel.Senior).Select(r => r.CalculateSalary()).Sum();
    }
}