using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SubLib.Facade
{
    public static class Common
    {
        public static string ToSubString(this TimeSpan ts)
        {
            return string.Format("{0:00}:{1:00}:{2:00},{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        public static TimeSpan ToTimeSpan(this string str)
        {
            TimeSpan start = DateTime.ParseExact(str.Trim(), "hh:mm:ss,fff", CultureInfo.InvariantCulture).TimeOfDay;
            return start;
        }
    }
}
