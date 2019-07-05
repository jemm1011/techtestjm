

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTestJM.Data.Model;
using TechTestJM.Data.Service.Interfaces;

namespace TechTestJM.Business.Tests
{
    [TestClass]
    public class EmployeeManagerTest
    {
        private Mock<IEmployeeService> _employeeService;

        [TestInitialize]
        public void Initialize()
        {
            var employeeMockList = new List<Employee>()
            {
                { new Employee
                    {
                        Id = 1,
                        ContractTypeName= "HourlySalaryEmployee",
                        HourlySalary = 1,
                        MonthlySalary=1,
                        RoleName="TestRole"
                    }
                },
                { new Employee
                    {
                        Id = 2,
                        ContractTypeName= "MonthlySalaryEmployee",
                        HourlySalary = 1,
                        MonthlySalary=1,
                        RoleName="TestRole"
                    }
                }
            };
            _employeeService = new Mock<IEmployeeService>();
            _employeeService.Setup(x => x.GetAll()).ReturnsAsync(employeeMockList);
        }

        [TestMethod]
        public async Task GetEmployees()
        {
            var employeeService = _employeeService.Object;
            var employees = await employeeService.GetAll();
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count == 2);
        }
    }
}
