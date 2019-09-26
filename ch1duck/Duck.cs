using System;

namespace ch1duck
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void SetFlyBehavior(IFlyBehavior fb) => flyBehavior = fb;
        public void SetQuackBehavior(IQuackBehavior qb) => quackBehavior = qb;

        public abstract void Display();
        public void PerformFly() => flyBehavior.Fly();
        public void PerformQuack() => quackBehavior.Quack();
        public void Swim() => System.Console.WriteLine("All ducks float, even decoys.");
    }
}