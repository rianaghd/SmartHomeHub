namespace SmartHomeHub.Observer;

// Subject interface i Observer pattern
// Subject är den del av systemet som skickar uppdateringar till observers

public interface ISubject
{
    // Lägger till en observer som ska få uppdateringar
    void AddObserver(IObserver observer);

    // Tar bort en observer
    void RemoveObserver(IObserver observer);

    // Skickar uppdatering till alla observers
    void NotifyObservers(string message);
}