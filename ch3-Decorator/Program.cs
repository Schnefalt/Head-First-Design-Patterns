using System;

namespace ch3_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new DarkRoast();
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");

            beverage = new Soy(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Mocha(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Mocha(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);
            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            beverage = new Whip(beverage);

            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            Console.ReadLine();
        }
    }
}
