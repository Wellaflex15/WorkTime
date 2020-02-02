using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTime
{
    public class Time
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Decimal GymTime { get; set; }
        public Decimal LunchTime { get; set; }

        public Time(DateTime startTime, DateTime endTime, Decimal gymTime = 0.0m, Decimal lunchTime = 1.0m)
        {
            StartTime = startTime;
            EndTime = endTime;
            GymTime = gymTime;
            LunchTime = lunchTime;
        }

        public Decimal CalculateWorkTime()
        {
            Decimal TotalWorkTime = 0.0m;

            TimeSpan differece = EndTime - StartTime;

            TotalWorkTime = Convert.ToDecimal(differece.TotalHours) - GymTime - LunchTime;

            return TotalWorkTime;
        }
    }
}
