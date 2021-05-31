using System;

namespace Ch09Ex01
{
    public abstract class myBase
    {

    }

    internal class MyClass : myBase
    {

    }

    public interface IMyBaseInterface
    {

    }

    public interface IMyBaseInterface2
    {

    }

    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {

    }

    internal sealed class MyComplexClass : MyClass, IMyInterface
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myObj1 = new MyComplexClass();
            Console.WriteLine(myObj1.ToString());
            Console.ReadKey();
        }
    }
}
