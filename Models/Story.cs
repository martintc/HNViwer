using System;
using System.Collections.Generic;

namespace HNViewer.Models
{
    public class Story
    {
        #region Data Members

        public String by { get; set; }
        public int id { get; set; }
        public int descendants { get; set; }
        public List<long> kids { get; set; }
        public int score { get; set; }
        public long time { get; set; }
        public String title { get; set; }
        public String type { get; set; }
        public String url { get; set; }

        #endregion

    }
}

