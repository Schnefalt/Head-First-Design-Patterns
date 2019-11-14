using System;

namespace ch4_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            PizzaStore nyStore = new NYPizzaStore();
          
            Console.Clear();

            pizza = nyStore.OrderPizza("cheese");
            System.Console.WriteLine(pizza.ToString());
            System.Console.WriteLine("\r\n");

            pizza = nyStore.OrderPizza("clam");
            System.Console.WriteLine(pizza.ToString());
            System.Console.WriteLine("\r\n");

        }
    }
}
