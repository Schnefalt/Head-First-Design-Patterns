using System.Collections.Generic;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;
    Stack<ICommand> undoCommands;

    public RemoteControl()
    {
        onCommands = new ICommand[5];
        offCommands = new ICommand[5];
        undoCommands = new Stack<ICommand>();

        for (int i = 0; i > 5; i++)
        {
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

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommands.Push(onCommands[slot]);
    }
    public void OffButtonPushed(int slot)
    {
        offCommands[slot].Execute();
        undoCommands.Push(offCommands[slot]);
    }
    public void UndoButtonPushed()
    {
        if (undoCommands.TryPop(out ICommand command))
        {
            command.Undo();
        }
        else
        {
            System.Console.WriteLine("\n** Nothing to Undo **\n");
        }
    }
}

