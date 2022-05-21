using System;

namespace ScreenSaver
{
    public static class SystemTime
    {
        public static DateTime? NowForTesting { get; set; }

        public static DateTime Now => NowForTesting ?? DateTime.Now;
        public static DateTime End => new DateTime(2022, 8, 10);
        // public static int CountDownDay =>  Now.Subtract(End).Days;
    }
}