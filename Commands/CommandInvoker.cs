using System;
using System.Collections.Generic;

namespace SmartHomeHub.Commands
{
    // Invoker hanterar och kör kommandon
    // Kan även logga historik och köra replay
    public class CommandInvoker
    {
        private List<ICommand> _commandHistory = new();

        // Kör ett command och sparar det i historik
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Add(command);
        }

        // Kör de senaste 5 kommandona igen (VG bonus)
        public void ReplayLastFive()
        {
            var lastFive = _commandHistory.Count > 5 
                ? _commandHistory.GetRange(_commandHistory.Count - 5, 5) 
                : new List<ICommand>(_commandHistory);

            foreach (var cmd in lastFive)
            {
                cmd.Execute();
            }
        }
    }
}