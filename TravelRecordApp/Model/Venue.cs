using System;
using System.Collections.Generic;
using System.Text;
using TravelRecordApp.Helpers;

namespace TravelRecordApp.Model
{
    public class Venue
    {
        public static void GenerateURL(double latitude, double longitude)
        {
            string url = string.Format(Constants.VENUE_SEARCH, latitude, longitude, Constants.CLIENT_ID,Constants.CLIENT_SECRET, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
