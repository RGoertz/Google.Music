﻿using System;

namespace GoogleMusicApi.UWP.Common
{
    public static class Time
    {
        private static readonly DateTime UnixEpoch =
            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static string GetCurrentTimestamp()
        {
            return GetCurrentUnixTimestampMillis().ToString("#");
        }

        public static long GetCurrentUnixTimestampMillis()
        {
            return (long) (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }
        public static string GetCurrentTimestampMicros()
        {
            return GetCurrentUnixTimestampMicros().ToString("#");
        }

        public static long GetCurrentUnixTimestampMicros()
        {
            return (long)(DateTime.UtcNow - UnixEpoch).TotalMilliseconds * 1000;
        }

        public static DateTime DateTimeFromUnixTimestampMillis(long millis)
        {
            return UnixEpoch.AddMilliseconds(millis);
        }

        public static long GetCurrentUnixTimestampSeconds()
        {
            return (long) (DateTime.UtcNow - UnixEpoch).TotalSeconds;
        }

        public static DateTime DateTimeFromUnixTimestampSeconds(long seconds)
        {
            return UnixEpoch.AddSeconds(seconds);
        }
    }
}