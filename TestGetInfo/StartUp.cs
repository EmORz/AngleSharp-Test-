using System;
using System.Linq;
using System.Net;
using System.Text;
using AngleSharp;
using AngleSharp.Html.Parser;

namespace TestGetInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var config = Configuration.Default.WithDefaultLoader();
            //var context = BrowsingContext.New(config);

            var parser = new HtmlParser();
            var webClient = new WebClient(){Encoding = Encoding.GetEncoding("windows-1251") };

            for (int i = 3000; i < 10000; i++)
            {
                var url = $"https://fun.dir.bg/vic_open.php?id={i}";
                var html = webClient.DownloadString(url);
                var document = parser.ParseDocument(html); //context.OpenAsync(url).GetAwaiter().GetResult();
                var jokeContent = document.QuerySelector("#newsbody")?.TextContent.Trim();
                var categoryName = document.QuerySelector(".tag-links-left a")?.TextContent.Trim();
                Console.WriteLine(jokeContent);
                Console.WriteLine(categoryName);
                

            }

           // var cells = document.QuerySelectorAll(cellSelector);



        }
    }
}
