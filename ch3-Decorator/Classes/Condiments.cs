public class Mocha : IBeverage
{
    IBeverage beverage;

    public Mocha(IBeverage b)
    {
        beverage = b;
    }

    public double GetCost() => beverage.GetCost() + .20;

    public string GetDescription() => beverage.GetDescription() + ", Mocha";
}

public class Soy : IBeverage
{
    IBeverage beverage;

    public Soy(IBeverage b)
    {
        beverage = b;
    }

    public double GetCost() => beverage.GetCost() + .15;

    public string GetDescription() => beverage.GetDescription() + ", Soy";
}

public class Whip : IBeverage
{
    IBeverage beverage;

    public Whip(IBeverage b)
    {
        beverage = b;
    }

    public double GetCost() => beverage.GetCost() + .10;

    public string GetDescription() => beverage.GetDescription() + ", Whip";
}
