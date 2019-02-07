using System;

namespace Timetable_Generator_4000x
{
    public struct TimeSpanDay
    {
        public DateTime startingTime;
        public DateTime endingTime;
        public DayEnum day;

        public TimeSpanDay(DateTime start, DateTime ende, DayEnum tag)
        {
            this.startingTime = start;
            this.endingTime = ende;
            this.day = tag;
        }
    }
}