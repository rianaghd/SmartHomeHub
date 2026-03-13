using System;
using SmartHomeHub.Devices; // För att kunna använda Lamp

namespace SmartHomeHub.Commands
{
    // Command som slår på en lampa
    public class TurnOnCommand : ICommand
    {
        private Lamp _lamp; // Den lampa kommandot gäller

        public TurnOnCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void Execute()
        {
            _lamp.TurnOn(); // Slår på lampan
        }
    }
}