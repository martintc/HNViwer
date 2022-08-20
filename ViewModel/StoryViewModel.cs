using System;
using System.Collections.ObjectModel;

using HNViewer.Models;

namespace HNViewer.ViewModel
{
    public class StoryViewModel
    {
        #region DataMembers

        readonly IList<Story> source;

        #endregion

        public StoryViewModel()
        {
            this.source = new List<Story>();
        }

        public StoryViewModel(StoryList stories)
        {

            this.source = stories;
            this.Stories = new ObservableCollection<Story>(this.source);

        }

        public ObservableCollection<Story> Stories { get; private set; }
    }
}

