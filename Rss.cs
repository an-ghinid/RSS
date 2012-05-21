using System;
using System.Collections.Generic;
using System.Text;

namespace PC
{
    public class Rss
    {

        [Serializable]
        public struct Items
        {

            public DateTime Date;
            public string Title;
            public string Description;
            public string Link;
        }
    }
}
