# SmartHomeHub

## Beskrivning
SmartHomeHub är ett litet Smart Home-system där man kan styra lampor, termostat och dörrlås. Systemet visar hur designmönster kan användas praktiskt för att skapa modulär och lättutbyggd kod. Alla actions, modes och uppdateringar hanteras via Facade, Command, Observer, Strategy och Singleton.

---

## Hur man kör programmet

1. Öppna terminalen i projektets root-mapp (`SmartHomeHub`).  
2. Bygg och kör projektet med:

```bash
dotnet build
dotnet run
-------------------------------------------------------------------------------
Designmönster

1️⃣ Observer
	•	Var i koden: Observer/ (DashboardObserver.cs, LoggerObserver.cs, AuditObserver.cs)
	•	Beskrivning: Flera subscribers får uppdateringar när en device ändrar state.
	•	Exempel: När lampan slås på notifieras Dashboard, Logger och Audit automatiskt.

2️⃣ Command
	•	Var i koden: Commands/ (TurnOnCommand.cs, SetTemperatureCommand.cs, LockDoorCommand.cs, CommandInvoker.cs)
	•	Beskrivning: Kommandon kapslar in handlingar som objekt och kan köras, loggas och replayas.
	•	Exempel: turnOnLamp, setTemp, lockDoor körs via hubben, och senaste 5 kan replayas med ReplayCommands().

3️⃣ Strategy
	•	Var i koden: Strategy/ (EcoMode.cs, NormalMode.cs, PartyMode.cs)
	•	Beskrivning: Systemets beteende kan ändras dynamiskt genom att byta mode.
	•	Exempel: EcoMode begränsar vissa funktioner, PartyMode tillåter batch-ändringar, NormalMode tillåter allt.

4️⃣ Facade
	•	Var i koden: Facade/SmartHomeFacade.cs
	•	Beskrivning: Förenklar användningen av systemet genom ett rent API.
	•	Exempel: AddDevice(), AddObserver(), RunCommand(), SetMode(), ReplayCommands() används för att styra hela systemet.

5️⃣ Singleton
	•	Var i koden: Singleton/Logger.cs
	•	Beskrivning: Logger har en gemensam instans som används av flera observers.
	•	Exempel: LoggerObserver skriver loggar via Logger.Instance.Log() från olika events.
    --------------------------------------------------------------------------
KlassDiagram:
SmartHomeFacade
├─ List<IDevice> devices
├─ List<IObserver> observers
├─ CommandInvoker invoker
├─ IModeStrategy mode
└─ Metoder: AddDevice(), AddObserver(), RunCommand(), SetMode(), ReplayCommands()

Devices
├─ IDevice (interface)
├─ Lamp : IDevice
├─ Thermostat : IDevice
└─ DoorLock : IDevice

Observer
├─ IObserver (interface)
├─ DashboardObserver : IObserver
├─ LoggerObserver : IObserver
└─ AuditObserver : IObserver

Commands
├─ ICommand (interface)
├─ TurnOnCommand : ICommand
├─ SetTemperatureCommand : ICommand
├─ LockDoorCommand : ICommand
└─ CommandInvoker

Strategy
├─ IModeStrategy (interface)
├─ EcoMode : IModeStrategy
├─ NormalMode : IModeStrategy
└─ PartyMode : IModeStrategy

Singleton
└─ Logger (singleton)
-----------------------------------------------------------------------------
DemoOutput:

Dashboard: Mode changed to EcoMode
LOG: Mode changed to EcoMode
Audit: Mode changed to EcoMode
Living Room lamp turned on
Dashboard: Command executed
LOG: Command executed
Audit: Command executed
Hall set to 21°C
Dashboard: Command executed
LOG: Command executed
Audit: Command executed
Front Door locked
Dashboard: Command executed
LOG: Command executed
Audit: Command executed
Living Room lamp turned on
Hall set to 21°C
Front Door locked
--------------------------------------------------------------
Reflektion:
Designmönster är kraftfulla verktyg för att skapa modulär, lättutbyggd och
underhållbar kod, men de ska användas med eftertanke. I små eller enkla projekt 
kan överanvändning av mönster göra koden onödigt komplex och svår att följa. 
Till exempel hade vi kunnat styra devices direkt i main-programmet utan Facade, 
men då hade systemet blivit svårare att utöka och återanvända. Balansen handlar 
om att använda mönster där de verkligen förenklar lösningen, och undvika dem där 
enkel kod räcker.
