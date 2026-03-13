namespace SmartHomeHub.Strategy;

// Strategy interface
// Definierar regler för hur systemet ska bete sig beroende på mode

public interface IModeStrategy
{
    // Bestämmer om en temperaturändring är tillåten
    bool AllowTemperatureChange(int temperature);
}