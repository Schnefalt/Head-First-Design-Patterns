using System;

namespace ch1duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new Mallard(
                new FlyWithWings(), 
                new MuteQuack());

            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.ReadLine();
        }
    }
}
