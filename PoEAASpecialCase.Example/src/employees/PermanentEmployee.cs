using PoEAASpecialCase.Example.Contracts;
using PoEAASpecialCase.Example.DailyRates;

namespace PoEAASpecialCase.Example.Employees;

public class PermanentEmployee : Employee
{
  public override decimal GrossToDate
  {
    get { return GrossDailyRates.PERMANENT * 30 / DateTime.Now.Day; }
  }

  public PermanentEmployee(string name) : base(name, Contract.PERMANENT) { }
}
