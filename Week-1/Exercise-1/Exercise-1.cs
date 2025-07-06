// Singleton Logger class
public class Logger
{
    private static Logger? instance;
    private Logger() { }
    public static Logger Instance
    {
        get
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }
    }
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

// Test Singleton in Main
class SingletonTest
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        logger1.Log("First message");
        logger2.Log("Second message");
        if (object.ReferenceEquals(logger1, logger2))
            Console.WriteLine("Both logger1 and logger2 are the same instance.");
        else
            Console.WriteLine("Different instances exist!");
    }
}
