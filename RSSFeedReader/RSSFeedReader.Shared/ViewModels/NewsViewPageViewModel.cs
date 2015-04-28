using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using RSSFeedReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.Web.Syndication;

namespace RSSFeedReader.ViewModels
{
    public class NewsViewPageViewModel: BindableBase
    {
        public SyndicationItem FeedNews { get; set; }

        //public string feedTitle { get; set; }
        //public string feedSource { get; set; }
        //public string feedAuthor { get; set; }
        //public string feedText { get; set; }

    }
}
