using System;
using System.Collections.Generic;
using System.Text;

namespace TakumiUtilities
{
    public class TimeSpanUtil
    {
    }
    public static class TimeSpanExternal
    {
        public static string ToStringEx(this TimeSpan ts, string format)
        {
            string dd = ts.ToString("dd");
            string hh = ts.ToString("hh");
            string mm = ts.ToString("mm");
            string ss = ts.ToString("ss");

            format = format.Replace("dd", dd);
            format = format.Replace("hh", hh);
            format = format.Replace("mm", mm);
            format = format.Replace("ss", ss);

            return format;
        }
    }
}
