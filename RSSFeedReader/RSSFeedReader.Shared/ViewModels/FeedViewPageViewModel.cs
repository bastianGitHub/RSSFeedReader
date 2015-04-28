using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using RSSFeedReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Windows.Web.Syndication;

namespace RSSFeedReader.ViewModels
{
    public class FeedViewPageViewModel: BindableBase
    {
        public ObservableCollection<SyndicationItem> News { get; set; }

        public FeedViewPageViewModel()
        {
            News = new ObservableCollection<SyndicationItem>();
        }

        public DelegateCommand CallNewsViewPage { get; private set; }

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
