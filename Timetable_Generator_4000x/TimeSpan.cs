using System;
namespace Timetable_Generator_4000x
{

    public struct TimeSpan
    {
        public DateTime start;
        public DateTime end;

        public DayEnum day;

        public TimeSpan(DateTime starting, DateTime ending)
        {
            day = 0;
            this.start = starting;
            this.end = ending;
        }
    }
}