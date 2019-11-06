public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    public abstract Pizza CreatePizza(string type);
}

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        switch (type) {
            case "cheese":
            return new NYStyleCheesePizza();
            
            case "veggie":
            return new NYStyleVeggiePizza();
            
            default :
            return null;
        }
    }
}

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        switch (type) {
            case "cheese":
            return new ChicagoStyleCheesePizza();
            
            case "veggie":
            return new ChicagoStyleVeggiePizza();
            
            default :
            return null;
        }
    }
}
