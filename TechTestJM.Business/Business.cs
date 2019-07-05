using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Business.Interfaces;

namespace TechTestJM.Business
{
    public class Business : IBusiness
    {
        public IEmployeeManager EmployeeManager { get; set; }
    }
}
