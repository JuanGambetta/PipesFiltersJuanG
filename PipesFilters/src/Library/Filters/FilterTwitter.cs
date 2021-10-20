using TwitterUCU;
using System;
namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("condicional1", @"filteredluke.jpg"));
            return image;
        }

    }
}