using System;
using SmartHomeHub.Devices; // För att kunna använda Thermostat

namespace SmartHomeHub.Commands
{
    // Command som sätter temperatur på en termostat
    public class SetTemperatureCommand : ICommand
    {
        private Thermostat _thermostat; // Termostat vi styr
        private int _temperature; // Temperatur att sätta

        public SetTemperatureCommand(Thermostat thermostat, int temperature)
        {
            _thermostat = thermostat;
            _temperature = temperature;
        }

        public void Execute()
        {
            _thermostat.SetTemperature(_temperature); // Kör kommandot
        }
    }
}