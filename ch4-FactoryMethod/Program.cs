using System;

namespace ch4_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Console.Clear();

            pizza = nyStore.OrderPizza("cheese");
            System.Console.WriteLine("\r\n");

            pizza = nyStore.OrderPizza("veggie");
            System.Console.WriteLine("\r\n");

            pizza = chicagoStore.OrderPizza("cheese");
            System.Console.WriteLine("\r\n");

            pizza = chicagoStore.OrderPizza("veggie");
            System.Console.WriteLine("\r\n");

        }
    }
}
