using PoEAASpecialCase.Example.Employees;
using PoEAASpecialCase.Example.Contracts;

namespace PoEAASpecialCase.Tests;

public class NullEmployeeTests
{
  private readonly Employee employee;

  public NullEmployeeTests() => employee = new NullEmployee();

  [Fact]
  public void TestReturnsNullAsName() => Assert.Equal("Null Employee", employee.Name);

  [Fact]
  public void TestReturnsZeroGrossForThePeriod() => Assert.Equal(0m, employee.GrossToDate);

  [Fact]
  public void TestReturnsNullContractType() => Assert.Equal(Contract.NULL, employee.Contract);
}
