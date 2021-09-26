using System;

namespace Rosered11.Aspnet.Utilities
{
    public static class DateTimeUtility
    {
        
        public static DateTimeOffset ChangeTimeZone(DateTime original, string timezoneId)
        {
            if(string.IsNullOrEmpty(timezoneId))
            {
                // UTC+07.00
                timezoneId = "SE Asia Standard Time";
            }
            TimeZoneInfo specificTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timezoneId);//.GetUtcOffset(original);
            return TimeZoneInfo.ConvertTime(original, specificTimeZone);
        }
    }
}