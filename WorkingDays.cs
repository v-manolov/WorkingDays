using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution9_WorkingDays
{
    class WorkingDays
    {
        public static int CountWorkingDays(DateTime today, DateTime nextDate)
        {
            int datesCount = (nextDate-today).Days;
            int workingDays = 0;
            for (int i = 0; i <= datesCount; i++)
            {
                workingDays++;
                if (today.DayOfWeek.Equals(DayOfWeek.Saturday)
                    || today.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    workingDays--;
                }
                else if (IsHoliday(today))
                {
                    workingDays--;
                }
                today = today.AddDays(1);
                int currentYear = today.Year;
            }
            return workingDays;
        }

        static bool IsHoliday(DateTime today)
        {
            int currentYear = today.Year;
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(currentYear,01,01),
                new DateTime(currentYear,03,03),
                new DateTime(currentYear,04,28),
                new DateTime(currentYear,05,01),
                new DateTime(currentYear,05,06),
                new DateTime(currentYear,05,24),
                new DateTime(currentYear,09,06),
                new DateTime(currentYear,12,24),
                new DateTime(currentYear,12,25),
                new DateTime(currentYear,12,26)
            };
            bool holiday = false;
            for (int i = 0; i < holidays.Length; i++)
            {
                if (today.Equals(holidays[i]))
                {
                    holiday = true;
                }
            }
            return holiday;
        }
    }
}
