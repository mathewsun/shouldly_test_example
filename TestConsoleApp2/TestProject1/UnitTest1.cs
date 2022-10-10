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

    [Fact]
    public async Task Test2()
    {
        Func<Task> doSomething = async () =>
        {
            var denominator = 0;
            var res = 10 / denominator;
            await Task.Delay(1);
        };
        var exception = await Should.ThrowAsync<DivideByZeroException>(() => doSomething());
    }

    [Fact]
    public async Task Test3()
    {
        var homer = new Person { Name = "Homer", Salary = 30000 };
        var denominator = 0;
        var action = () =>
        {
            var y = homer.Salary / denominator;
        };
        action.ShouldThrow<DivideByZeroException>();
    }

    [Fact]
    public async Task Test4()
    {
        Should.Throw<ArgumentNullException>(() => new Person("Homer"));
    }

}