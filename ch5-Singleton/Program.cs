using System;

namespace ch5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var uno = Singleton2.GetInstance();

            Console.WriteLine(uno.ToString());
        }
    }
}
