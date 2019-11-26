using System;

namespace ch6_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();

            var kitchenLight = new Light("Kitchen");
            var livingroomLight = new Light("Living room");
            var fan = new CeilingFan("Bed room");

            var kitchenLightOn = new KitchenLightOn(kitchenLight);
            var kitchenLightOff = new KitchenLightOff(kitchenLight);
            var livingRoomLightOn = new KitchenLightOn(livingroomLight);
            var livingRoomLightOff = new KitchenLightOff(livingroomLight);
            var fanOn = new CeilingFanOn(fan);
            var fanOff = new CeilingFanOff(fan);

            remote.SetCommand(0, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(2, fanOn, fanOff);

            remote.OnButtonPushed(0);
            remote.OnButtonPushed(1);
            
            System.Console.WriteLine("\n--- Undo once:");
            remote.UndoButtonPushed();
            System.Console.WriteLine();

            remote.OnButtonPushed(2);
            remote.OnButtonPushed(2);
            remote.OnButtonPushed(2);
            remote.OnButtonPushed(2);
            remote.OffButtonPushed(2);
            remote.OffButtonPushed(1);
            remote.OffButtonPushed(0);

            System.Console.WriteLine("\n--- Undo fest:");
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
            remote.UndoButtonPushed();
        }
    }
}
