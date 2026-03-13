namespace SmartHomeHub.Strategy;

// NormalMode är standardläget
// Här finns inga restriktioner

public class NormalMode : IModeStrategy
{
    public bool AllowTemperatureChange(int temperature)
    {
        // Alla temperaturer tillåts
        return true;
    }
}