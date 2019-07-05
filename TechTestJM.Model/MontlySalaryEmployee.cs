using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Model.Abstract;

namespace TechTestJM.Model
{
    public class MontlySalaryEmployee : Employee
    {
        public override double AnnualSalary { get { return Salary * 12; } }
    }
}
