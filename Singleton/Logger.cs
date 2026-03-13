namespace SmartHomeHub.Singleton;

// Logger implementerar Singleton pattern
// Detta säkerställer att det bara finns en logger i hela systemet

public class Logger
{
    // Statisk variabel som håller instansen
    private static Logger? _instance;

    // Global access point till loggern
    public static Logger Instance
    {
        get
        {
            // Om ingen instans finns skapas en
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance!;
        }
    }

    // Privat konstruktor gör att ingen annan kan skapa nya instanser
    private Logger() { }

    // Metod för att skriva loggmeddelanden
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}