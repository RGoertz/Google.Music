﻿using GoogleMusicApi;
using GoogleMusicApi.Requests.Data;
using GoogleMusicApi.Structure;

namespace GooglePlayMusic.Desktop.Managers
{
    public static class SessionManager
    {
        public static ListListenNowSituationResponse ListenNowSituationResponse { get; set; }
        public static ListListenNowTracksResponse ListenNowTracksResponse { get; set; }
        public static MobileSession MobileSession { get; set; }
    }
}