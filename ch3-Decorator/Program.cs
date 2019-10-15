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
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            System.Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost()}\n");
            Console.ReadLine();
        }
    }
}
