using System.Collections.Generic;

public class ThinCrustDough : IDough
{

}
public class MarinaraSauce : ISauce
{

}
public class ReggianoCheese : ICheese
{

}
public class SlicedPepperoni : IPepperoni
{

}
public class FreshClams : IClams
{

}
public class NYVeggies : IVeggies
{
    public List<string> ToList()
    {
        return new List<string>() {
            "Garlic",
            "Onion",
            "Mushroom",
            "Red Pepper"
        };
    }
}