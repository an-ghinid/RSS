using System;
using System.Collections.ObjectModel;
using System.Xml;
using PC;

public class RssManager : IDisposable
{
    private string url, feedtitle, description;
    private bool isDisposed;
    public Collection<Rss.Items> rssItems = new Collection<Rss.Items>();


    public RssManager()
    {
        url = string.Empty;
    }
    
    public RssManager(string feed)
    {
        feedtitle = feed;
    }

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public string Title
    {
        get { return feedtitle; }
    }

    public Collection<Rss.Items> Items
    {
        get { return rssItems; }
    }

    public Collection<Rss.Items> getFeed()
    {
        if (String.IsNullOrEmpty(Url))
        {
            throw new ArgumentException("You must provide a valid feed URL");
        }

        using (XmlReader reader = XmlReader.Create(Url))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "title", ref feedtitle);
            ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "description", ref description);
            ParseRssItems(xmlDoc);


            return rssItems;
        }
    }
    private void ParseRssItems(XmlDocument xmlDoc)
    {
        rssItems.Clear();

        XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item");

        foreach (XmlNode node in nodes)
        {
            Rss.Items item = new Rss.Items();
            ParseDocElements(node, "title", ref item.Title);
            ParseDocElements(node, "description", ref item.Description);
            ParseDocElements(node, "link", ref item.Link);

            string date = null;
            ParseDocElements(node, "pubDate", ref date);
            DateTime.TryParse(date, out item.Date);

            rssItems.Add(item);
        }
    }

   
    private void ParseDocElements(XmlNode parent, string xPath, ref string property)
    {
        XmlNode node = parent.SelectSingleNode(xPath);
        if (node != null)
            property = node.InnerText;
        else
            property = "Unresolvable";
    }

    #region IDisposable Members
    private void Dispose(bool disposing)
    {
        if (disposing && !isDisposed)
        {
            rssItems.Clear();
            url = null;
            feedtitle = null;
            description = null;
        }

        isDisposed = true;
    }

    /// <summary>
    /// Releases the object to the garbage collector
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    #endregion




}

