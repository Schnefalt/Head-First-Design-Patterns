using System.Collections.Generic;

public abstract class Pizza
{
    public string name;
    public string dough;
    public string sauce;
    public List<string> toppings = new List<string>();

    public void Prepare()
    {
        System.Console.WriteLine($"Preparing {name}");
        System.Console.WriteLine("Tossing dough...");
        System.Console.WriteLine("Adding sauce...");
        System.Console.WriteLine("Adding toppings:");
        foreach (var topping in toppings)
        {
            System.Console.WriteLine($"\t{topping}");
        }
    }

    public void Bake() => System.Console.WriteLine("Bake for 25 minutes at 350.");
    public void Cut() => System.Console.WriteLine("Cutting the pizza into diagonal slices.");
    public void Box() => System.Console.WriteLine("Place pizza in official PizzaStore box.");
    public string GetName() => name;
}

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        name = "NY Style Sauce and Cheese Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";

        toppings.Add("Grated  Reggiano Cheese");
    }
}

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        toppings.Add("Shredded Mozzarella Cheese");
    }
}