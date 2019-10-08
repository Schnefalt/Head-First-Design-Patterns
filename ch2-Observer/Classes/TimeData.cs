using System.Collections.Generic;

public class TimeData : IObservable
{
    private List<IObserver> observers;
    int second = 0;
    int lastSecond = 0;

    public TimeData()
    {
        observers = new List<IObserver>();
    }

    public void NotifyObservers()
    {
        foreach(var o in observers){
            o.Update(second);
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetSecond(int s)
    {
        second = s;
        if(second != lastSecond){
            NotifyObservers();
            lastSecond = second;
        }
    }
}