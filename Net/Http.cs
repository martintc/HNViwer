using System;
using System.Text.Json;
using HNViewer.Models;

namespace HNViewer.Net
{
    public class Http
    {
        public Http()
        {
        }

        public static async Task<List<long>> GetStoryIds()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://hacker-news.firebaseio.com/v0/topstories.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<long> storyIds = JsonSerializer.Deserialize<List<long>>(responseBody);
                return storyIds;
            } catch (HttpRequestException e)
            {
                throw;
            } catch (Exception e)
            {
                throw;
            }
        }

        public static async Task<Story> GetStory(long id)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"https://hacker-news.firebaseio.com/v0/item/{id}.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Story story = JsonSerializer.Deserialize<Story>(responseBody);
                return story;
            }
            catch (HttpRequestException e)
            {
                throw;
            } catch (Exception e)
            {
                throw;
            }
        }
    }
}

