namespace SmartHomeHub.Observer;

// Observer interface
// Alla observers implementerar denna
// Update körs när systemet skickar en uppdatering

public interface IObserver
{
    // Metod som körs när ett event händer i systemet
    // message innehåller information om vad som har hänt
    void Update(string message);
}