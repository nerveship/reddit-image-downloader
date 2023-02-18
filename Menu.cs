using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reddit_image_downloader
{
    internal class Menu
    {
        internal void MainMenu()
        {
            var date = DateTime.Now;
            string UserChoice = "";
            string SubredditChoice = "";
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
                    Console.WriteLine("Which user profile would you like to download from?");
                    UserChoice = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Which subreddit would you like to download from?");
                    SubredditChoice = Console.ReadLine();
                    break;
            }
        }
        
    }
}       