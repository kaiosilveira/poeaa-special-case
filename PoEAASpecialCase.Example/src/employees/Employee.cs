using PoEAASpecialCase.Example.Contracts;

namespace PoEAASpecialCase.Example.Employees;

public class Employee
{
  public string Name { get; set; }

  public Contract Contract { get; private set; }

  public virtual decimal GrossToDate { get; }

  public Employee(string name, Contract contract)
  {
    Name = name;
    Contract = contract;
  }
}
