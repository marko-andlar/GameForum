using System;
using System.Globalization;

namespace GameForum.Helper
{
    public static class Activity
    {
        public static string FromDates(DateTime dateCreated, DateTime? dateEdited)
        {
            return dateEdited is null ? DateToActivity(dateCreated) : DateToActivity((DateTime)dateEdited);
        }
        public static string DateToActivity(DateTime date)
        {
            var elapsedTime = DateTime.Now - date;
            if (elapsedTime.TotalDays >= 30 && date.Year < DateTime.Now.Year)
            {
                return date.ToString("MMM \"'\"yy", DateTimeFormatInfo.InvariantInfo);
            }
            else if (elapsedTime.TotalDays >= 7)
            {
                return date.ToString("MMM", DateTimeFormatInfo.InvariantInfo);
            }
            else if (elapsedTime.TotalDays >= 1)
            {
                return date.ToString("ddd", DateTimeFormatInfo.InvariantInfo);
            }
            else if (elapsedTime.TotalHours >= 1)
            {
                return (int)elapsedTime.TotalHours + "h";
            }
            else if (elapsedTime.TotalMinutes >= 1)
            {
                return (int)elapsedTime.TotalMinutes + "m";
            }
            else
            {
                return (int)elapsedTime.TotalSeconds + "s";
            }
        }
    }
}
