# shouldly_test_example


succes tests https://docs.shouldly.org/documentation/exceptions/throw


Throw
ShouldThrowAction
var homer = new Person { Name = "Homer", Salary = 30000 };
var denominator = 1;
Should.Throw<DivideByZeroException>(() =>
                {
                    var y = homer.Salary / denominator;
                });
​ | ​
Exception
`var y = homer.Salary / denominator;`
    should throw
System.DivideByZeroException
    but did not
ShouldThrowAsync
Func<Task> doSomething = async () =>
{
    await Task.Delay(1);
};
var exception = await Should.ThrowAsync<DivideByZeroException>(() => doSomething());
​ | ​
Exception
Task doSomething() should throw System.DivideByZeroException but did not
ShouldThrow Action Extension
var homer = new Person { Name = "Homer", Salary = 30000 };
var denominator = 1;
var action = () =>
                {
                    var y = homer.Salary / denominator;
                };
action.ShouldThrow<DivideByZeroException>();
​ | ​
Exception
`action()`
    should throw
System.DivideByZeroException
    but did not
ShouldThrowFunc
Should.Throw<ArgumentNullException>(() => new Person("Homer"));
​ | ​
Exception
`new Person("Homer")`
    should throw
System.ArgumentNullException
    but did not
ShouldThrow Func Extension
var func = () => new Person("Homer");
func.ShouldThrow<ArgumentNullException>();
​ | ​
Exception
`func()`
    should throw
System.ArgumentNullException
    but did not
ShouldThrowFuncOfTask
var homer = new Person { Name = "Homer", Salary = 30000 };
var denominator = 1;
Should.Throw<DivideByZeroException>(() =>
                {
                    var task = Task.Factory.StartNew(
                        () =>
                        {
                            var y = homer.Salary / denominator;
                        });
                    return task;
                });
​ | ​
Exception
Task `var task = Task.Factory.StartNew( () => { var y = homer.Salary / denominator; }); return task;`
    should throw
System.DivideByZeroException
    but did not
