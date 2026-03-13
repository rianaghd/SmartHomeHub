namespace SmartHomeHub.Devices;

// Representerar ett smart dörrlås
public class DoorLock : IDevice
{
    public string Name { get; }

    // State: låst eller upplåst
    public bool IsLocked { get; private set; }

    public DoorLock(string name)
    {
        Name = name;
    }

    // Låser dörren
    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{Name} locked");
    }

    // Låser upp dörren
    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{Name} unlocked");
    }
}