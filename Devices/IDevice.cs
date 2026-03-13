namespace SmartHomeHub.Devices;

// Interface för alla smarta enheter i systemet
// Gör att hubben kan hantera olika typer av devices på samma sätt
public interface IDevice
{
    string Name { get; }
}