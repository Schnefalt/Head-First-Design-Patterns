using System;

namespace ch7_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simplified example of the Facade pattern:
            var a = new A();
            var b = new B();
            var c = new C();

            var f = new JustAFacade(a, b, c);

            f.TurnEmOn();
            f.TurnEmOff();

            Console.ReadKey();
        }
    }
}
