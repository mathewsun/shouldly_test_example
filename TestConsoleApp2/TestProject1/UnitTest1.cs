using Shouldly;
using TestConsoleApp2;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test9991()
    {
    }

    [Fact]
    public void Test1()
    {
        Program.TestWorks().ShouldBe("Works");
    }

    [Fact]
    public void Test11()
    {
        var homer = new Person { Name = "Homer", Salary = 30000 };
        var denominator = 0;
        Should.Throw<DivideByZeroException>(() =>
        {
            var y = homer.Salary / denominator;
        });
    }

}