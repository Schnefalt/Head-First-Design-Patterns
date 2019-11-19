public class Singleton
{
    private static volatile Singleton uniqueInstance = null;
    private static object threadLock = new object();
    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (uniqueInstance == null)
        {
            lock (threadLock)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new Singleton();
                }
            }
        }

        return uniqueInstance;
    }

    public override string ToString() => "There can be only one!";
}

public class Singleton2
{
    private Singleton2() { }

    public static Singleton2 GetInstance() => Nested.uniqueInstance;

    public override string ToString() => "One is the loneliest number...";
    private class Nested
    {
        static Nested() { }
        internal static readonly Singleton2 uniqueInstance = new Singleton2();
    }
}