public interface IDuck
{
    void Quack();
    void Fly();
}

public interface ITurkey
{
    void Gobble();
    void Fly();
}


public class MallardDuck : IDuck
{
    public void Fly() => System.Console.WriteLine("Flap, flap!");

    public void Quack() => System.Console.WriteLine("Quack!");
}

public class WildTurkey : ITurkey
{
    public void Fly() => System.Console.WriteLine("Barely flying...");

    public void Gobble() => System.Console.WriteLine("Gobble, gobble!");

}

public class TurkeyAdapter : IDuck
{
    private ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Fly()
    {
        _turkey.Fly();
    }

    public void Quack()
    {
        _turkey.Gobble();
    }
}