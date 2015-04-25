using RSSFeedReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.Web.Syndication;
using RSSFeedReader.Common;

namespace RSSFeedReader.ViewModels
{
    public class FeedViewViewModel
    {
        private SyndicationItem _feedNews;

        public SyndicationItem FeedNews { 
            get{ return this._feedNews; }
            set { this._feedNews = FeedNews; }
        }
        //public string feedTitle { get; set; }
        //public string feedSource { get; set; }
        //public string feedAuthor { get; set; }
        //public string feedText { get; set; }

        public FeedViewViewModel()
        {
        }
    }
}
