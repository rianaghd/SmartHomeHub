using System;
using System.Collections.Generic;
using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using SmartHomeHub.Commands;
using SmartHomeHub.Strategy;
using SmartHomeHub.Singleton;

namespace SmartHomeHub.Facade; 
// SmartHomeFacade förenklar hela systemet
// Den fungerar som en "hub" som kontrollerar devices, commands och observers

public class SmartHomeFacade
{
    // Lista över alla devices i systemet
    private List<IDevice> devices = new();

    // Lista över observers som ska få uppdateringar
    private List<IObserver> observers = new();

    // Invoker används för att köra commands
    private CommandInvoker invoker = new();

    // Aktuell strategi (mode)
    private IModeStrategy mode = new NormalMode();

    // Lägger till en device i systemet
    public void AddDevice(IDevice device)
    {
        devices.Add(device);
    }

    // Registrerar en observer
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    // Skickar uppdatering till alla observers
    private void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    // Kör ett command via invoker
    public void RunCommand(ICommand command)
    {
        invoker.ExecuteCommand(command);

        // Informerar observers att ett command körts
        NotifyObservers("Command executed");
    }

    // Byter systemets mode
    public void SetMode(IModeStrategy newMode)
    {
        mode = newMode;

        NotifyObservers($"Mode changed to {newMode.GetType().Name}");
    }

    // Replay funktion (VG-krav)
    public void ReplayCommands()
    {
        invoker.ReplayLastFive();
    }
}