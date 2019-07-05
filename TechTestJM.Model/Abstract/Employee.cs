namespace TechTestJM.Model.Abstract
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractType { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }
        public abstract double AnnualSalary { get; }
    }
}
