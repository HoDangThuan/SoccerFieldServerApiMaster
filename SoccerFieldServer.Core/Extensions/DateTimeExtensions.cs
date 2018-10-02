using System;

namespace SoccerFieldServer.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetCurrentTimeZoneTime(string timeZoneId = "Pacific Standard Time")
        {
            return DateTime.UtcNow.ToTimeZoneTime(timeZoneId);
        }

        public static DateTime GetStartDateFromCurrentTimeZoneTime(string timeZoneId = "Pacific Standard Time")
        {
            var currentTimeZoneTime = GetCurrentTimeZoneTime(timeZoneId);
            return currentTimeZoneTime.GetStartDateTimeZoneTime(timeZoneId);
        }

        public static DateTime GetStartDateTimeZoneTime(this DateTime dt, string timeZoneId = "Pacific Standard Time")
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            var offset = tzi.GetUtcOffset(dt);
            return dt.StartTimeOfDate().Subtract(offset);
        }

        public static DateTime GetEndDateFromCurrentTimeZoneTime(string timeZoneId = "Pacific Standard Time")
        {
            var currentTimeZoneTime = GetCurrentTimeZoneTime(timeZoneId);
            return currentTimeZoneTime.GetEndDateTimeZoneTime(timeZoneId);
        }

        public static DateTime GetEndDateTimeZoneTime(this DateTime dt, string timeZoneId = "Pacific Standard Time")
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            var offset = tzi.GetUtcOffset(dt);
            return dt.EndTimeOfDate().Subtract(offset);
        }

        public static DateTime ToUtcTime(this DateTime dt, TimeZoneInfo tzi)
        {
            return TimeZoneInfo.ConvertTimeToUtc(dt, tzi);
        }

        public static DateTime ToUtcTime(this DateTime dt, string timeZoneId = "Pacific Standard Time")
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return dt.ToUtcTime(tzi);
        }

        public static DateTime ToTimeZoneTime(this DateTime dt, TimeZoneInfo tzi)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dt, tzi);
        }

        public static DateTime ToTimeZoneTime(this DateTime dt, string timeZoneId = "Pacific Standard Time")
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return dt.ToTimeZoneTime(tzi);
        }

        private static DateTime StartTimeOfDate(this DateTime dt)
        {
            return dt.Date;
        }

        private static DateTime EndTimeOfDate(this DateTime dt)
        {
            return dt.StartTimeOfDate().AddDays(1).AddTicks(-1);
        }
    }
}
