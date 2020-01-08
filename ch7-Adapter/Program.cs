using System;

namespace ch7_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck md = new MallardDuck();
            WildTurkey wd  = new WildTurkey();
            IDuck ta = new TurkeyAdapter(wd);

            System.Console.WriteLine("\r\nMallard Duck:");
            md.Quack();
            md.Fly();

            System.Console.WriteLine("\r\nWild Turkey:");
            wd.Gobble();
            wd.Fly();

            System.Console.WriteLine("\r\nTurkey Adapter:");
            ta.Quack();
            ta.Fly();

            Console.ReadKey();
        }
    }
}
