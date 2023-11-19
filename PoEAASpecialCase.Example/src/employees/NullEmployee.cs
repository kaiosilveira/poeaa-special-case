using PoEAASpecialCase.Example.Contracts;

namespace PoEAASpecialCase.Example.Employees;

public class NullEmployee : Employee
{
  public NullEmployee() : base("Null Employee", Contract.NULL) { }

  public override decimal GrossToDate { get { return 0m; } }
}
