using JustBlog.Core.Objects;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace JustBlog
{
    public  static class Extensions
    {
        public static string ToConfigLocalTime(this DateTime utcDT)
        {
            var tzi = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");
            return String.Format("{0} ({1})", TimeZoneInfo.ConvertTimeFromUtc(utcDT, tzi).ToShortDateString(), ConfigurationManager.AppSettings["TimezoneAbbr"]);
        }
    }
}