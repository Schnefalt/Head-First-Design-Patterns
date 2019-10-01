using System;

namespace ch1duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new Mallard(
                new FlyWithWings(), 
                new NormalQuack());

            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            mallard.SetFlyBehavior(new FlyRocketPowered());
            mallard.SetQuackBehavior(new MuteQuack()); // In space, no one can hear you quack.
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.ReadLine();
        }
    }
}
