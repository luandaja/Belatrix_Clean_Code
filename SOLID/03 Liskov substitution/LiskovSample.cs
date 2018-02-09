using System;

namespace SOLID._03_Liskov_substitution
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }

        decimal GetMinimumSalary();
    }
    public interface IEmployeeWithBonus
    {
        decimal CalculateBonus(decimal salary);
    }

    public abstract class Employee : IEmployee
    {
        public Employee(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;

        }
        public Employee()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal GetMinimumSalary();
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee(int iD, string name) : base(iD, name)
        { }
        public ContractEmployee()
        { }

        public override decimal GetMinimumSalary()
        {
            return 0;
        }
    }

    public class PermanentEmployee : Employee, IEmployeeWithBonus
    {

        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 0;
        }
    }

    public class TemporaryEmployee : Employee, IEmployeeWithBonus
    {
        public TemporaryEmployee(int iD, string name)
        { }
        public TemporaryEmployee()
        { }
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 0;
        }
    }
}