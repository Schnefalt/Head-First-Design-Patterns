public class DarkRoast : IBeverage
{
    public double GetCost() => 0.99;

    public string GetDescription() => "Dark Roast";
}

public class Decaf : IBeverage
{
    public double GetCost() => 1.05;

    public string GetDescription() => "Defaf";
}