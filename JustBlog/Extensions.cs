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
            //時區設定 可以針對不同區域顯示不同的區域時間
            var tzi = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");
            return String.Format("{0} ({1})", TimeZoneInfo.ConvertTimeFromUtc(utcDT, tzi).ToShortDateString(), ConfigurationManager.AppSettings["TimezoneAbbr"]);
        }
    }
}