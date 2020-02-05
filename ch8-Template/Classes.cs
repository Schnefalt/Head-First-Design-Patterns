public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();   
    }

    // These will be implemented by the child classes:
    public abstract void Brew();
    public abstract void AddCondiments();

    // Shared methods:
    public void BoilWater() => System.Console.WriteLine("\tBoiling water");
    public void PourInCup() => System.Console.WriteLine("\tPouring in cup");
}

public class Tea : CaffeineBeverage
{
    public override void Brew() => System.Console.WriteLine("\tSteeping the tea");
    public override void AddCondiments() => System.Console.WriteLine("\tAdding lemon");
}

public class Coffee : CaffeineBeverage
{
    public override void Brew() => System.Console.WriteLine("\tPouring water over grounds");
    public override void AddCondiments() => System.Console.WriteLine("\tAdding milk and sugar");
}
