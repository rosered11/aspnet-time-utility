using System;

namespace Rosered11.Aspnet.Utilities
{
    public static class DatetimeUtility
    {
        
        public static DateTimeOffset ChangeTimeZone(DateTime original, string timezoneId)
        {
            if(string.IsNullOrEmpty(timezoneId))
            {
                // UTC+07.00
                timezoneId = "SE Asia Standard Time";
            }
            TimeSpan timeSpan = TimeZoneInfo.FindSystemTimeZoneById("").GetUtcOffset(original);
            return new DateTimeOffset(original, timeSpan);
        }
    }
}