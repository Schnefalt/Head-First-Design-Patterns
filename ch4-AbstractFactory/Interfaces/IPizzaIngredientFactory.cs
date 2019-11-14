using System.Collections.Generic;

public interface IPizzaIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IVeggies CreateVeggies();
    IPepperoni CreatePepperoni();
    IClams CreateClams();
}

public interface IDough
{
    string ToString();
}
public interface ISauce
{
    string ToString();
}
public interface ICheese
{
    string ToString();
}
public interface IVeggies
{
    string ToString();
}
public interface IPepperoni
{
    string ToString();
}
public interface IClams
{
    string ToString();
}