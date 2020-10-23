class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
        CallC();
        CallB();
    }

    static void CallB() => new B();
    static void CallC() => new C();
}

abstract class A<T>
{
    public abstract A<T> M();
}

class B : A<string>
{
    public override B M() => new B();
}

class C : A<int>
{
    public override C M() => new C();
}