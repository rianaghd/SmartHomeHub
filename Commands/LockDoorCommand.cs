using System;
using SmartHomeHub.Devices; // För att kunna använda DoorLock

namespace SmartHomeHub.Commands
{
    // Command som låser en dörr
    public class LockDoorCommand : ICommand
    {
        private DoorLock _door; // Dörr vi styr

        public LockDoorCommand(DoorLock door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Lock(); // Låser dörren
        }
    }
}