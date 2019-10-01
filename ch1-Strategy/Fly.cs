using System;

namespace ch1duck
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => System.Console.WriteLine("I'm, flying!!");
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => System.Console.WriteLine("I can't fly...");
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly() => System.Console.WriteLine("I'm a rockt duck!");
    }
}