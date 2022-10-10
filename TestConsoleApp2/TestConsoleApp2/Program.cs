namespace TestConsoleApp2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string TestWorks()
        {
            return "Works";
        }
    }
}


public class Person
{
    public Person()
    {
    }

    public Person(string name)
    {
        Name = name;
        throw (new ArgumentNullException());
    }

    public string Name { get; set; }
    public int Salary { get; set; }
}