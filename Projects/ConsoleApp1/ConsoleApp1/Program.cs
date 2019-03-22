using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;


namespace Airbrake.Net.WebException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to Airbrake.io.
            ParseTest("https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes");

            Console.ReadKey();
        }

        static void ParseTest(string uri)
        {
           
                // Generate document using AngleSharp.
                var document = WebParser.GetHtmlDocument(uri);
            // Get all h1 and h2 headers from document, concat into single 
            // collection, and then get TextContent and insert into array.
            var headers = document.QuerySelectorAll("tr.vevent td:nth-child(3)").Select(element => element.TextContent).ToArray();
            // Output title and headers to test if connection was successful.
           
            foreach (var header in headers) 
            {
                Console.WriteLine(header);
            }


        }
    }

    public static class WebParser
    {
        public static IHtmlDocument GetHtmlDocument(string uri)
        {
            HttpContent content;
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            HtmlParser parser = new HtmlParser();

          
                // Get async result from uri.
                response = client.GetAsync(uri).Result;
                // Get response content.
                content = response.Content;
                // Read result string (HTML).
                var result = content.ReadAsStringAsync().Result;
                // Parse HTML and return produced IHtmlDocument.
                return parser.Parse(result);
         
            

          
        }
    }
}