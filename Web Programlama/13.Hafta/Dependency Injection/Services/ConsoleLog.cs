namespace FurOfTheWeak.Services
{
    public class ConsoleLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Konsoloa loglandi");
        }
    }
}
