namespace SmartHomeHub.Strategy;

// PartyMode är mer tillåtande
// Tanken är att huset kan vara varmare och mer aktivt

public class PartyMode : IModeStrategy
{
    public bool AllowTemperatureChange(int temperature)
    {
        // Party mode tillåter högre temperatur
        return temperature <= 26;
    }
}