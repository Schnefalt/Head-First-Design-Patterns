
public class JustAFacade
{
    private A _a;
    private B _b;
    private C _c;

    public JustAFacade(A a, B b, C c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public void TurnEmOn()
    {
        _a.On();
        _b.On();
        _c.On();
    }

    public void TurnEmOff()
    {
        _a.Off();
        _b.Off();
        _c.Off();
    }

}

public class A
{
    public void On() => System.Console.WriteLine("A class is on.");
    public void Off() => System.Console.WriteLine("A class is off.");
}

public class B
{
    public void On() => System.Console.WriteLine("B class is on.");
    public void Off() => System.Console.WriteLine("B class is off.");
}

public class C
{
    public void On() => System.Console.WriteLine("C class is on.");
    public void Off() => System.Console.WriteLine("C class is off.");
}