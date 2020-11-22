using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;

namespace TechnicalMVCApp
{
    public static  class APIConnection
    {
        public static HttpClient APIClient = new HttpClient();
        static APIConnection()
        {
            APIClient.BaseAddress = new Uri("http://localhost:18320/api/");
            APIClient.DefaultRequestHeaders.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}