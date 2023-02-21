using HtmlAgilityPack;
using System.Linq;

namespace reddit_image_downloader
{
    internal class ImageDownload
    {
        internal void SubredditDownload()
        {
            Console.WriteLine("Which subreddit would you like to download images from?");
            string UserChoice = Console.ReadLine();
        }

        internal void UserDownload()
        {
            Console.Clear();
            Console.WriteLine("Which user would you like to download images from?");

            string UserChoice = Console.ReadLine();
            var TargetUrl = new HtmlWeb().Load($"https://www.reddit.com/u/{UserChoice}");

            var ImageUrls = TargetUrl.DocumentNode.Descendants("img")
                .Select(i => i.GetAttributeValue("src", ""))
                .Where(e => e.Contains("i.redd.it"));

            //For each image that contains i.reddit, print the link
            foreach (string image in ImageUrls)
            {
                Console.WriteLine(image);
            }
        }
    }
}
