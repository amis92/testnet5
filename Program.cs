class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
        Bug();
    }

    static void Bug() => new B();
}

abstract class A<T>
{
    public abstract A<T> M();
}

class B : A<string>
{
    public override B M() => new B();
}
