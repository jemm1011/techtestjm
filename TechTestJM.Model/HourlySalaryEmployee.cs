using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Model.Abstract;

namespace TechTestJM.Model
{
    public class HourlySalaryEmployee : Employee
    {
        public override double AnnualSalary { get { return 120 * Salary * 12; } }
    }
}
