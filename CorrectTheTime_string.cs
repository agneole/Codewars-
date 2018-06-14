using System;
using System.Collections.Generic;
using System.Linq;

public static class Time
{
    public static string Correct(string timeString)
    {
        if (timeString == "")
        {
            return "";
        }
        if (timeString == null || timeString.Length != 8)
        {
            return null;
        }

        int hours, mins, sec;
        bool var1 = int.TryParse((timeString.Substring(0, 2)), out hours);        
        bool var2 = int.TryParse((timeString.Substring(3, 2)), out mins);       
        bool var3 = int.TryParse((timeString.Substring(6, 2)), out sec);


        if (var1 == false || var2 == false || var3 == false || timeString.ElementAt(2) != ':' || timeString.ElementAt(5) != ':')
        {
            return null;
        }
        if (sec >= 60)
        {
            sec = sec - 60;
            mins++;
        }

        if (mins >= 60)
        {
            mins = mins - 60;
            hours++;
        }

        while (hours >= 24)
        {
            hours = hours - 24;
        }

        return ($"{hours.ToString("00")}:{mins.ToString("00")}:{sec.ToString("00")}");
    }
}
