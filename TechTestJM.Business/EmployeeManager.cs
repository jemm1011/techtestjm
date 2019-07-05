using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Business.Interfaces;
using TechTestJM.Data.Service.Interfaces;
using TechTestJM.Model.Abstract;
using TechTestJM.Model.Interfaces;

namespace TechTestJM.Business
{
    public class EmployeeManager : IEmployeeManager
    {
        private IEmployeeService employeeService;
        private IEmployeeFactory employeeFactory;

        public EmployeeManager(IEmployeeService employeeService, IEmployeeFactory employeeFactory)
        {
            this.employeeService = employeeService;
            this.employeeFactory = employeeFactory;
        }

        public async Task<Employee> GetById(int id)
        {
            var employee = await employeeService.GetById(id);
            return employeeFactory.Create(employee);
        }

        public async Task<List<Employee>> GetAll()
        {
            var employees = await employeeService.GetAll();
            return employees.Select(e => employeeFactory.Create(e)).ToList();
        }
    }
}
