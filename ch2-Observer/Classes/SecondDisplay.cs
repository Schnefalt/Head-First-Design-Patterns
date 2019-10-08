public class SecondDisplay : IObserver, IDisplay
{
    int second;
    public void Display()
    {
        System.Console.WriteLine($"Here's your second: {second}.");
    }

    public void Update(int sec)
    {
        second = sec;
        Display();
    }
}