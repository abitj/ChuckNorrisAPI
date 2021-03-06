using KanyeWest;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace ChuckNorrisAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitString = "";
            do
            {
                Console.WriteLine();
                NorrisQuote.GetQuote();
                KanyeQuote.GetQuote();
                RonQuote.GetQuote();
                

                Console.WriteLine();
                Console.WriteLine("___________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Press Enter key to continue reading more quotes. Type exit to close the application");
                Console.WriteLine("___________________________________________________________________________________");
                exitString = Console.ReadLine();

            } while (exitString.ToLower() != "exit");
        }

    }
}
