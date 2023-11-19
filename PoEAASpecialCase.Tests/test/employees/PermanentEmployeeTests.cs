using PoEAASpecialCase.Example.Employees;
using PoEAASpecialCase.Example.Contracts;
using PoEAASpecialCase.Example.DailyRates;

namespace PoEAASpecialCase.Tests;

public class PermanentEmployeeTests
{
    public readonly Employee employee;

    public PermanentEmployeeTests()
    {
        employee = new PermanentEmployee("John Doe");
    }

    [Fact]
    public void TestReturnsTheCorrectName() => Assert.Equal("John Doe", employee.Name);

    [Fact]
    public void TestReturnsPermanentGrossRateForThePeriod()
    {
        var grossToDate = GrossDailyRates.PERMANENT * 30 / DateTime.Now.Day;
        Assert.Equal(grossToDate, employee.GrossToDate);
    }

    [Fact]
    public void TestReturnsPermanentContractType()
    {
        Assert.Equal(Contract.PERMANENT, employee.Contract);
    }
}
