using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestJM.Model.Abstract;
using TechTestJM.Model.Enum;
using TechTestJM.Model.Interfaces;

namespace TechTestJM.Model.Factories
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee Create(object param)
        {
            var employeeDao = (TechTestJM.Data.Model.Employee)param;
            switch (employeeDao.ContractTypeName)
            {
                case nameof(ContractType.HourlySalaryEmployee):
                    return new HourlySalaryEmployee
                    {
                        ContractType = employeeDao.ContractTypeName,
                        Id = employeeDao.Id,
                        Name = employeeDao.Name,
                        Role = employeeDao.RoleName,
                        Salary = employeeDao.HourlySalary
                    };
                case nameof(ContractType.MonthlySalaryEmployee):
                    return new MontlySalaryEmployee
                    {
                        ContractType = employeeDao.ContractTypeName,
                        Id = employeeDao.Id,
                        Name = employeeDao.Name,
                        Role = employeeDao.RoleName,
                        Salary = employeeDao.MonthlySalary
                    };
                default:
                    throw new ArgumentException("Wrong contract type");
            }
        }
    }
}
