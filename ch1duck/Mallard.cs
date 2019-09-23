using ch1duck;

namespace ch1duck
{
    public class Mallard : Duck
    {
        public Mallard(IFlyBehavior fly, IQuackBehavior quack)
        {
            flyBehavior = fly;
            quackBehavior = quack;
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm a mallard.");
        }
    }
}