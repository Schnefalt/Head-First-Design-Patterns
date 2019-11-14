using System.Collections.Generic;

public class ThinCrustDough : IDough
{
    public override string ToString()
    {
        return "Thin Crust Dough";
    }
}
public class MarinaraSauce : ISauce
{
    public override string ToString()
    {
        return "Marinara Sauce";
    }
}
public class ReggianoCheese : ICheese
{
    public override string ToString()
    {
        return "Reggiano Cheese";
    }
}
public class SlicedPepperoni : IPepperoni
{
    public override string ToString()
    {
        return "Sliced Pepperoni";
    }
}
public class FreshClams : IClams
{
    public override string ToString()
    {
        return "Fresh Juicy Clams";
    }
}
public class NYVeggies : IVeggies
{
    public override string ToString()
    {
        return "Garlic, Onion, Mushroom, Red Pepper";
    }
}