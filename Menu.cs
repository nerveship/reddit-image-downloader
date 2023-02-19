namespace reddit_image_downloader
{
    internal class Menu
    {
        ImageDownload imageDownload = new();
        internal void MainMenu()
        {
            var date = DateTime.Now;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to the Reddit Image Downloader");
            Console.WriteLine($"Todays date and time is {date}");
            Console.WriteLine("What would you like to download today?\n" +
            "1. Images from user profile\n" +
            "2. Images from subreddit page");
            Console.WriteLine("---------------------------------------");

            int Choice = 0;
            Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    imageDownload.UserDownload();
                    break;
                case 2:
                    imageDownload.SubredditDownload();
                    break;
            }
        }
    }
}       