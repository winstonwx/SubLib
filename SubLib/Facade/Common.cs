using System;
using System.Globalization;

namespace SubLib.Facade
{
    public static class Common
    {
        public static string ToSubString(this TimeSpan ts)
        {
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00},{ts.Milliseconds:000}";
        }

        public static TimeSpan ToTimeSpan(this string str)
        {
            var start = DateTime.ParseExact(str.Trim(), "hh:mm:ss,fff", CultureInfo.InvariantCulture).TimeOfDay;
            return start;
        }
    }
}
