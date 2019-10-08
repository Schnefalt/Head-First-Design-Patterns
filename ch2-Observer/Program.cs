using System;

namespace ch2_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new TimeData();
            string input = "";

            clock.RegisterObserver(new SecondDisplay());
            clock.RegisterObserver(new SecondDisplay());
            clock.RegisterObserver(new SecondDisplay());

            System.Console.WriteLine("Hit enter to update second. (x + <enter> to quit...)");

            do {
               input = Console.ReadLine();
               clock.SetSecond(DateTime.Now.Second);

            } while (input.ToUpper().Trim() != "X");

        }
    }
}
