using System;
using System.Collections.Generic;
using System.Text;

namespace BookCar.Utils
{
    public static class Utility
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";

        private const string DATE_TIME_FORMAT = "HH:mm:ss dd/MM/yyyy";

        private const string FORMAT_DATE = "dd/MM/yyyy HH:mm:ss tt";
        public static string GetHoursDuration(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            return Math.Round(duration.TotalHours).ToString() ;
        }
        public static int CompateStringDate(string startTime, string endTime)
        {
            DateTime start = Convert.ToDateTime(startTime);
            DateTime end = Convert.ToDateTime(endTime);
            TimeSpan duration = end - start;
            if (duration.TotalHours < 0)
                return 0;
            else return 1;

        }
        public static string GetDaysDuration(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            return Math.Round(duration.TotalDays).ToString();
        }
        public static string DateTimeToString(DateTime Time)
        {
            return Time.ToString(FORMAT_DATE);
        }
        public static DateTime? GetNullableDate(string value)
        {
            DateTime dt;
            bool isValid = DateTime.TryParseExact(value, DATE_FORMAT, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt);
            if (!string.IsNullOrEmpty(value) && isValid)
            {
                return dt;
            }
            else
                return null;
        }
    }
}
