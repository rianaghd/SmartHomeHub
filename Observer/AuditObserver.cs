namespace SmartHomeHub.Observer;

// AuditObserver används för spårning och säkerhet
// Den kan t.ex. användas för att kontrollera vem som gjorde vad

public class AuditObserver : IObserver
{
    public void Update(string message)
    {
        // Simulerar att audit-systemet registrerar händelsen
        Console.WriteLine($"Audit: {message}");
    }
}