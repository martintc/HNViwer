using System;
using HNViewer.Models;
using HNViewer;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using HNViewer.Net;

namespace HNViewer.Controllers
{
    public class HNViewerStoryController
    {
        #region Data Members
        private StoryList model;
        private ContentPage view;
        #endregion

        public HNViewerStoryController(ContentPage view)
        {
            this.model = new StoryList();
            this.view = view;
        }

        public async Task<StoryList> RefreshStories()
        {
            try
            {
                List<long> ids = await HNViewer.Net.Http.GetStoryIds();
                this.model = new StoryList();
                foreach (long id in ids)
                {
                    Story s = await HNViewer.Net.Http.GetStory(id);
                    this.model.Add(s);
                }
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine("Done gathering data");

            return this.model;
        }
    }
}

