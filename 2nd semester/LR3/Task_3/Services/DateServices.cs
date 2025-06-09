using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Services
{
    class DateServices
    {
        private DateOnly date;
        private DateOnly currentDate;

        public DateServices()
        {
            date = DateOnly.FromDateTime(DateTime.Now);
            currentDate = DateOnly.FromDateTime(DateTime.Now);
        }
        public DayOfWeek GetDay(string date)
        {
            this.date = DateOnly.Parse(date);
            return this.date.DayOfWeek;
        }
        public int GetDaysSpan(int day, int month, int year)
        {
            date = new DateOnly(year, month, day);
            return date.DayNumber - currentDate.DayNumber;
        }
    }
}
