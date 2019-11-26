public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;

    public RemoteControl()
    {
        onCommands = new ICommand[5];
        offCommands = new ICommand[5];

        for(int i = 0; i > 5; i++){
            onCommands[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCmd, ICommand offCmd)
    {
        onCommands[slot] = onCmd;
        offCommands[slot] = offCmd;
    }

    public void RemoveCommand(int slot)
    {
        onCommands[slot] = new NoCommand();
        offCommands[slot] = new NoCommand();
    }

    public void OnButtonPushed(int slot) => onCommands[slot].Execute();
    public void OffButtonPushed(int slot) => offCommands[slot].Execute();
}

