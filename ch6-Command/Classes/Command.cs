public interface ICommand
{
    void Execute();
}

public class NoCommand : ICommand
{
    public void Execute() { }
}

public class KitchenLightOn : ICommand
{
    Light _light;
    public KitchenLightOn(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.On();
    }
}

public class KitchenLightOff : ICommand
{
    Light _light;
    public KitchenLightOff(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.Off();
    }
}

public class LivingRoomLightOn : ICommand
{
    Light _light;
    public LivingRoomLightOn(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.On();
    }
}

public class LivingRoomLightOff : ICommand
{
    Light _light;
    public LivingRoomLightOff(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.Off();
    }
}

public class CeilingFanOn : ICommand
{
    CeilingFan _fan;
    public CeilingFanOn(CeilingFan fan)
    {
        _fan = fan;
    }
    public void Execute()
    {
        _fan.On();
    }
}

public class CeilingFanOff : ICommand
{
    CeilingFan _fan;
    public CeilingFanOff(CeilingFan fan)
    {
         _fan = fan;
    }
    public void Execute()
    {
        _fan.Off();
    }
}
