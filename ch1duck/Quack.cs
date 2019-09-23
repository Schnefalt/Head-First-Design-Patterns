using System;

namespace ch1duck
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class NormalQuack : IQuackBehavior
    {
        public void Quack() => System.Console.WriteLine("Quack!!");
    }

        public class MuteQuack : IQuackBehavior
    {
        public void Quack() => System.Console.WriteLine("<silence>");
    }

}