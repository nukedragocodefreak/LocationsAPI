using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Utility
{
    public static class Urls
    {
        public static string BaseUri = "https://api.foursquare.com/v2/";
        public static string client_id = "3QLIE2CJOVDRDUPC005VKY5S14ONGS4LJH3V12GVYS3IIYDR";
        public static string client_secret = "4H43YM0HRH3LUNI0WD3A2FRHJVMOFGTKA1FI1JB3XCQKOOIL";


        public static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}
