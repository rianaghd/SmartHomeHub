using SmartHomeHub.Singleton;

namespace SmartHomeHub.Observer
{
    // LoggerObserver skickar systemhändelser till Logger singleton
    public class LoggerObserver : IObserver
    {
        public void Update(string message)
        {
            // Skickar meddelandet till Logger singleton
            Logger.Instance.Log(message);
        }
    }
}