using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class ClockTime
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour => hour;
        public int Minute => minute;
        public int Second => second;

        public ClockTime(int hour=0,int minute=0,int second=0)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override bool Equals(object obj)
        {
            var clocktime = obj as ClockTime;
            if (clocktime == null)
                return false;
            if (hour != clocktime.Hour)
                return false;
            if (minute != clocktime.Minute)
                return false;
            if (second != clocktime.Second)
                return false;
            return true;
        }

    }
}
