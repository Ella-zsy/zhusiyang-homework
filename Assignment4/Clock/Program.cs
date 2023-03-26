using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AlarmClock clock = new AlarmClock(); //时钟
                clock.AlarmTime = new ClockTime(DateTime.Now.Hour,
                              DateTime.Now.Minute,
                              DateTime.Now.Second + 6);//设置响铃时间为当前时间5秒后

                clock.AlarmEvent += PlayMusic;//响铃时间增加playmusic函数

                int sum = 0;
                clock.TickEvent += (c => Count(c, ref sum));//滴答事件增加总共滴答了多少次函数
                new Thread(clock.Run).Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Count(AlarmClock sender, ref int sum)
        {
            ClockTime time = sender.CurrentTime;
            sum = sum + 1;
            Console.WriteLine($"Sum= {sum}");
        }

        public static void PlayMusic(AlarmClock sender)
        {
            ClockTime time = sender.CurrentTime;
            Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("Playing music....");
        }
    }
}
