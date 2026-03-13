namespace SmartHomeHub.Observer;

// DashboardObserver representerar ett UI eller dashboard
// Den visar live information till användaren

public class DashboardObserver : IObserver
{
    // Denna metod körs när systemet skickar en uppdatering
    public void Update(string message)
    {
        // Simulerar att dashboarden visar information
        Console.WriteLine($"Dashboard: {message}");
    }
}