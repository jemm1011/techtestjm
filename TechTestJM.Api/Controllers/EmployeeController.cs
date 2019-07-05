using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TechTestJM.Business.Interfaces;
using TechTestJM.Model.Abstract;

namespace TechTestJM.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        public IBusiness Business { get; set; }

        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            var listResponse = await Business.EmployeeManager.GetAll();
            return listResponse;
        }

        [HttpGet]
        public async Task<Employee> GetEmployee(int id)
        {
            var reponse = await Business.EmployeeManager.GetById(id);
            return reponse;
        }
    }
}
