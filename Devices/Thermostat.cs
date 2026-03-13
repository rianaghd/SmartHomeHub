namespace SmartHomeHub.Devices;

// Thermostat representerar temperaturkontroll i huset
public class Thermostat : IDevice
{
    public string Name { get; }

    // Aktuell temperatur
    public int Temperature { get; private set; }

    public Thermostat(string name)
    {
        Name = name;
    }

    // Ändrar temperatur
    public void SetTemperature(int temp)
    {
        Temperature = temp;

        Console.WriteLine($"{Name} set to {temp}°C");
    }
}