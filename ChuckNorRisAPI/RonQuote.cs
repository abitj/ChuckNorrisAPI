using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    public class RonQuote
    {
        public RonQuote()
        {

        }
        public static void GetQuote()
        {

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var client2 = new HttpClient();
            var ronResponse = client2.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron Swanson says: {ronQuote}");
            Console.WriteLine();

        }
    }
}
