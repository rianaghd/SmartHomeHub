namespace SmartHomeHub.Strategy;

// EcoMode är en konkret Strategy
// Den försöker spara energi genom att begränsa temperaturen

public class EcoMode : IModeStrategy
{
    public bool AllowTemperatureChange(int temperature)
    {
        // I eco mode tillåts temperatur upp till 22 grader
        return temperature <= 22;
    }
}