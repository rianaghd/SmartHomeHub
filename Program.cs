using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using SmartHomeHub.Commands;
using SmartHomeHub.Strategy;
using SmartHomeHub.Singleton;
using SmartHomeHub.Facade;

var hub = new SmartHomeFacade();

// Skapar några devices
var lamp = new Lamp("Living Room");
var thermostat = new Thermostat("Hall");
var door = new DoorLock("Front Door");


// Lägger till devices i systemet
hub.AddDevice(lamp);
hub.AddDevice(thermostat);
hub.AddDevice(door);


// Registrerar observers
hub.AddObserver(new DashboardObserver());
hub.AddObserver(new LoggerObserver());
hub.AddObserver(new AuditObserver());


// Byter systemets mode
hub.SetMode(new EcoMode());


// Skapar commands
var turnOnLamp = new TurnOnCommand(lamp);
var setTemp = new SetTemperatureCommand(thermostat, 21);
var lockDoor = new LockDoorCommand(door);


// Kör commands via hubben
hub.RunCommand(turnOnLamp);
hub.RunCommand(setTemp);
hub.RunCommand(lockDoor);


// Replay senaste commands
hub.ReplayCommands();