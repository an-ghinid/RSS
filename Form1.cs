using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PC;




public partial class Form1 : Form
{
    //create our FeedManager & FeedList items
    RssManager reader = new RssManager();
    ListViewItem row;
    Collection<Rss.Items> list;
    




    public Form1()
    {
        InitializeComponent();
        

    }
    private void cmdGet_Click(object sender, EventArgs e)
    {
        try
        {
            
            //execute the GetRssFeeds method in out
            //FeedManager class to retrieve the feeds
            //for the specified URL
            reader.Url = txtURL.Text;
            reader.getFeed();
            list = reader.rssItems;
            //list = reader
            //now populate out ListBox
            //loop through the count of feed items returned
            for (int i = 0; i < list.Count; i++)
            {
                //add the title, link and public date
                //of each feed item to the ListBox
                row = new ListViewItem();
                row.Text = list[i].Title;
                row.SubItems.Add(list[i].Link);
                row.SubItems.Add(list[i].Date.ToShortDateString());
                lstNews.Items.Add(row);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private void lstNews_SelectedIndexChanged(object sender, EventArgs e)
    {
        //check to make sure an item is selected
        if (lstNews.SelectedItems.Count == 1)
        {
            // Loop through all the items in the list
            for (int i = 0; i < list.Count; i++)
            {
                //check and see if the selected title
                //in the ListBox matches the current 
                //of the list
                if (list[i].Title == lstNews.SelectedItems[0].Text)
                {
                    //set the description to the TextBox.Text
                    txtContent.Text = list[i].Description.Substring(0, 250);
                }
            }
        }
    }

    private void lstNews_DoubleClick(object sender, EventArgs e)
    {
        // When double clicked open the web page
        System.Diagnostics.Process.Start(lstNews.SelectedItems[0].SubItems[1].Text);
    }







    public static void Main()
    {
        Application.Run(new Form1());
    }
}




