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
        Pizza pizza = null;
        IPizzaIngredientFactory factory = new NYPizzaIngredientFactory();

        switch (type) {
            case "cheese":
            pizza = new CheesePizza(factory);
            pizza.SetName("NY Style Cheese Pizza");
            break;

            case "clam":
            pizza = new ClamPizza(factory);
            pizza.SetName("NY Style Clam Pizza");
            break;
        }

        return pizza;
    }
}