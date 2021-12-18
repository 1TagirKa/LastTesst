using System;
using System.Web;
using Microsoft.AspNetCore.Http;
using Ubiety.Dns.Core;

namespace LastTesst.Cookie
{
    public static class Cookies
    {
        public static CookieOptions cookieOptions = new CookieOptions();
        public static string key = "userEmail";

        public static string email = "";
        //CookieOptions.Expires = DateTime.Now.AddDays(1)
        public static string getCookie(string value)
        {
            //Response.Cookies.Append(key, value, cookieOptions);
            return email;
        }
    }
}