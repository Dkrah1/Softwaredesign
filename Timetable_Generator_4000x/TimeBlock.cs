using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Timetable_Generator_4000x
{
    class TimeBlock
    {
        public TimeSpan time;
        public int number;
        public List<Course> course;

        public DayEnum day;


        public TimeBlock(TimeSpan time, int number, DayEnum day)
        {
            this.time = time;
            this.number = number;
            this.day = day;
        }

    }
}