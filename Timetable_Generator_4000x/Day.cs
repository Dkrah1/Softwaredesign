using System;
using System.Collections.Generic;

namespace Timetable_Generator_4000x
{
    class Day
    {
    public DayEnum day;
    public List <TimeBlock> timeBlockNumber;
    public Day (DayEnum day)
    {
        this.day = day;
    }
    }
}