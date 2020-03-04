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
        public TimeSpan GymTime { get; set; }
        public TimeSpan LunchTime { get; set; }
        private decimal _workTime { get; set; }

        public Time(DateTime startTime, DateTime endTime, TimeSpan gymTime, TimeSpan lunchTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            GymTime = gymTime;
            LunchTime = lunchTime;
        }

        public Decimal CalculateWorkTime()
        {
            Decimal TotalWorkTime = 0.0m;

            //Changed the calculation to match 38.5 hours per week or 7.7 work hours per day.  
            //LunchTime = TimeSpan.FromHours(1.0).Subtract(LunchTime);
            //TimeSpan differece = (EndTime - StartTime) - GymTime + LunchTime;

            TimeSpan differece = (EndTime - StartTime) - GymTime - LunchTime;

            TotalWorkTime = Convert.ToDecimal(differece.TotalHours);

            _workTime = TotalWorkTime;

            TotalWorkTime = Decimal.Round(TotalWorkTime, 1);

            return TotalWorkTime;
        }

        public Decimal CalculateTimeBank()
        {
            decimal workTime = _workTime - 7.7m;

            workTime = Decimal.Round(workTime, 1);

            return workTime;
        }
    }
}
