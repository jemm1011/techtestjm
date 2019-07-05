using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Data.Model;
using TechTestJM.Data.Service.Abstract;
using TechTestJM.Data.Service.Interfaces;
using TechTestJM.Support.JsonHelper;

namespace TechTestJM.Data.Service
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        private IJsonRequestHelper jsonRequestHelper;
        private string ServiceUrl = string.Empty;

        public EmployeeService(IJsonRequestHelper jsonRequestHelper)
        {
            this.jsonRequestHelper = jsonRequestHelper;
            ServiceUrl = BaseUrl + "Employees";
        }

        public async Task<List<Employee>> GetAll()
        {
            return await jsonRequestHelper.Get<List<Employee>>(ServiceUrl);
        }

        public async Task<Employee> GetById(int id)
        {
            var employees = await GetAll();
            return employees.FirstOrDefault(em => em.Id == id);
        }
    }
}
