using System;

namespace ch8_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            var tea = new Tea();

            System.Console.WriteLine("\nLet's make some coffee!");
            coffee.PrepareRecipe();

            System.Console.WriteLine("\nAnd some tea!");
            tea.PrepareRecipe();
            
            Console.ReadKey();
        }
    }
}
