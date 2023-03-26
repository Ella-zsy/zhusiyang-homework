using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class AlarmClock
    {
        public event Action<AlarmClock> AlarmEvent;
        public event Action<AlarmClock> TickEvent;

        public ClockTime CurrentTime { get; set; }
        public ClockTime AlarmTime { get; set; }

        public AlarmClock()
        {
            CurrentTime = new ClockTime();
            AlarmEvent += c => Console.WriteLine("Ling!");
            TickEvent += c => Console.WriteLine("Tick!" + CurrentTime);
        }

        public void Run()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                CurrentTime = new ClockTime(now.Hour, now.Minute, now.Second);
                TickEvent(this);
                if (AlarmTime.Equals(CurrentTime))
                    AlarmEvent(this);
                Thread.Sleep(1000);
            }
        }
    }
}
