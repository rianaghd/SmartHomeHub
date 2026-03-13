using System;

namespace SmartHomeHub.Commands
{
    // Interface för alla commands
    // Gör att vi kan köra alla kommandon på samma sätt
    public interface ICommand
    {
        void Execute(); // Metod som kör kommandot
    }
}