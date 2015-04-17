using RSSFeedReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.Web.Syndication;

namespace RSSFeedReader.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<SyndicationItem> News { get; set; }

        public MainPageViewModel()
        {
            News = new ObservableCollection<SyndicationItem>();
        }

        public async void LoadNews()
        {
            RSSFeed rssFeedReader = new RSSFeed();

            var news = await rssFeedReader.LoadNewsAsync();

            foreach (SyndicationItem syndicationItem in news)
            {
                News.Add(syndicationItem);
            }
        }
    }
}
