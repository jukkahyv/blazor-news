using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BlazorNews.Shared;
using Microsoft.AspNetCore.Blazor;

namespace BlazorNews.Client.Repositories {
	public class TopicsRepository {

		private readonly HttpClient http;

		public TopicsRepository(HttpClient http) {
			this.http = http;
		}

		public async Task<IEnumerable<string>> GetTopicsAsync() {
			var topics = await http.GetJsonAsync<Topic[]>("api/topics");
			return topics.Select(t => t.TopicValue);
		}

		public async Task AddTopicAsync(string topic) {
			await http.PostJsonAsync("api/topics", new Topic { TopicValue = topic });
		}

		public async Task RemoveTopicAsync(string topic) {
			await http.DeleteAsync($"api/topics?topic={HttpUtility.UrlEncode(topic)}");
		}

	}
}
