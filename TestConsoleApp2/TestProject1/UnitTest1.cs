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

}