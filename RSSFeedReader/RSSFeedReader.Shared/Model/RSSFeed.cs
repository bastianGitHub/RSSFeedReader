using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Syndication;

namespace RSSFeedReader.Model
{
    public class RSSFeed
    {
        public string strFeedName { get; set; }
        public Uri UriFeedIdentifier { get; set; }



        public async Task<IList<SyndicationItem>> LoadNewsAsync()
        {
            SyndicationClient syndicationClient = new SyndicationClient();
            var feeds = await syndicationClient.RetrieveFeedAsync(new Uri("http://golem.de.dynamic.feedsportal.com/pf/578068/http://rss.golem.de/rss.php?feed=RSS2.0"));

            //return feeds.Items;
        }
    }
}
