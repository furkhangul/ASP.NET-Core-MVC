using System;
namespace FurOfTheWeak.Models
{
    public class ConsoleLog : ILog
    {
        public int deger { get; set; }
        public ConsoleLog()
        {
            Random rnd = new Random();
            int deger = rnd.Next(1, 100);
        }

        public void LogYaz()
        {
            Console.WriteLine($"Console Log Yazıldı. Tutulduğu Class = {deger}");
        }
    }
}




