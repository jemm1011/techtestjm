using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Business.Interfaces
{
    public interface IBusiness
    {
        IEmployeeManager EmployeeManager { get; set; }
    }
}
