using OpenClosed_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy._2nd
{
    internal class DeveloperReport : OpenClosed_Principle.DeveloperReport
    {
        public DeveloperLevel Level { get; set; }
        public double CalculateSalary() => WorkingHours * HourlyRate;
    }
}
//public class DeveloperReport
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Level { get; set; }
//    public int WorkingHours { get; set; }
//    public double HourlyRate { get; set; }
//}
