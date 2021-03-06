using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    public class NorrisQuote
    {
        public NorrisQuote()
        {
        }

        public static void GetQuote()
        {
            var norrisURL = "https://api.chucknorris.io/jokes/random";
            var client = new HttpClient();
            var norrisResponse = client.GetStringAsync(norrisURL).Result;
            var norrisQuote = JObject.Parse(norrisResponse).GetValue("value").ToString();
            Console.WriteLine($"Chuck Norris Says:  \"{norrisQuote}\"");
            Console.WriteLine();
            

        }
    }
}




//namespace KanyeWest
//{
//    public class RonQuote
//    {
//        public RonQuote()
//        {

//        }
//        public static void GetQuote()
//        {

//            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
//            var client2 = new HttpClient();
//            var ronResponse = client2.GetStringAsync(ronURL).Result;
//            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

//            Console.WriteLine($"Ron says: {ronQuote}");
//            Console.WriteLine();

//        }
//    }
