namespace SmartHomeHub.Devices;

// Lamp är en konkret device i systemet
// Den implementerar IDevice så att hubben kan hantera den generiskt
public class Lamp : IDevice
{
    public string Name { get; }

    // State för lampan
    public bool IsOn { get; private set; }

    public Lamp(string name)
    {
        Name = name;
    }

    // Action som ändrar state
    public void TurnOn()
    {
        IsOn = true;

        // Simulerar att lampan faktiskt slås på
        Console.WriteLine($"{Name} lamp turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} lamp turned off");
    }
}