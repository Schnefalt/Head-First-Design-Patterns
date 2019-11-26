public class Light
{
    private string location;

    public Light(string locn)
    {
        location = locn;
    }

    public void On() => System.Console.WriteLine($"{location} light is on");
    public void Off() => System.Console.WriteLine($"{location} light is off");
}

public class CeilingFan
{
    private string location;
    private int fanSpeed = 0;

    public CeilingFan(string locn)
    {
        location = locn;
    }

    public void On()
    {
        switch (fanSpeed) {
            case 3:
            case 2:
                fanSpeed --;
                break;
            case 1:
            case 0:
                fanSpeed = 3;
                break;
        }

        System.Console.WriteLine($"{location} ceiling fan is on at speed: {fanSpeed}");
    }
    public void Off()
    {
        fanSpeed = 0;
        System.Console.WriteLine($"{location} ceiling fan is off");
    }
}
