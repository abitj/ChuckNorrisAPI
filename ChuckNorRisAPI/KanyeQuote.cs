using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    public class KanyeQuote
    {
        public KanyeQuote()
        {
        }

        public static void GetQuote()
        {
            var kanyeURL = "https://api.kanye.rest";
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye West Says:  \"{kanyeQuote}\"");
            Console.WriteLine();
        }
    }
}
