using System.Text;

public abstract class Pizza
{
    public string name;

    public IDough dough;
    public ISauce sauce;
    public IVeggies veggies;
    public ICheese cheese;
    public IPepperoni pepperoni;
    public IClams clams;

    public abstract void Prepare();

    public void Bake() => System.Console.WriteLine("Bake for 25 minutes at 350");
    public void Cut() => System.Console.WriteLine("Cutting the pizza in diagonal slices");
    public void Box() => System.Console.WriteLine("Place pizza in official PizzaStore box");
    public void SetName(string n) => name = n;
    public string GetName() => name;
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"\n{name}:");
        sb.AppendLine($"\tDough:     {dough?.ToString() ?? "[none]"}");
        sb.AppendLine($"\tSauce:     {sauce?.ToString() ?? "[none]"}");
        sb.AppendLine($"\tVeggies:   {veggies?.ToString() ?? "[none]"}");
        sb.AppendLine($"\tCheese:    {cheese?.ToString() ?? "[none]"}");
        sb.AppendLine($"\tPepperoni: {pepperoni?.ToString() ?? "[none]"}");
        sb.AppendLine($"\tClams:     {clams?.ToString() ?? "[none]"}\n\n");

        return sb.ToString();
    }
}

public class CheesePizza : Pizza
{
    IPizzaIngredientFactory factory;
    
    public CheesePizza(IPizzaIngredientFactory f)
    {
        factory = f;
    }

    public override void Prepare()
    {
        System.Console.WriteLine($"Preparing {name}");
        dough = factory.CreateDough();
        sauce = factory.CreateSauce();
        cheese = factory.CreateCheese();
    }
}

public class ClamPizza : Pizza
{
    IPizzaIngredientFactory factory;
    
    public ClamPizza(IPizzaIngredientFactory f)
    {
        factory = f;
    }

    public override void Prepare()
    {
        System.Console.WriteLine($"Preparing {name}");
        dough = factory.CreateDough();
        sauce = factory.CreateSauce();
        cheese = factory.CreateCheese();
        clams = factory.CreateClams();
    }
}