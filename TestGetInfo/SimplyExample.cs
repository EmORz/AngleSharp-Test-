using AngleSharp;

namespace TestGetInfo
{
    public class SimplyExample
    {
        var config = Configuration.Default.WithDefaultLoader();
        var address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
        var context = BrowsingContext.New(config);
        var document = context.OpenAsync(address);
        var cellSelector = "tr.vevent td:nth-child(3)";
        var cells = document.QuerySelectorAll(cellSelector);
       //var titles = cells.Select(m => m.TextContent);
    }
}