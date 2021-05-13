using System;

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
            if (elapsedTime.TotalDays >= 365)
            {
                return (int)elapsedTime.TotalDays / 365 + "y";
            }
            else if (elapsedTime.TotalDays >= 30)
            {
                return (int)elapsedTime.TotalDays / 30 + "m";
            }
            else if (elapsedTime.TotalDays >= 1)
            {
                return (int)elapsedTime.TotalDays + "d";
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
