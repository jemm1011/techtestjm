using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Model.Abstract;

namespace TechTestJM.Model.Interfaces
{
    public interface IEmployeeFactory : IBaseFactory<Employee>
    {
    }
}
