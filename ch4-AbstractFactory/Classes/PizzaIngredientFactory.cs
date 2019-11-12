
using System.Collections.Generic;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new ReggianoCheese();

    public IClams CreateClams()
    {
        return new FreshClams();
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IVeggies CreateVeggies()
    {
        return new NYVeggies();
    }

}