using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorNews.Shared;
using Microsoft.AspNetCore.Blazor;

namespace BlazorNews.Client.Repositories {
	public class TopicsRepository {

		private readonly HttpClient http;

		public TopicsRepository(HttpClient http) {
			this.http = http;
		}

		private List<Topic> topics = new List<Topic>();

		public async Task<IEnumerable<string>> GetTopicsAsync() {
			var topics = await http.GetJsonAsync<Topic[]>("api/topics");
			this.topics = this.topics.ToList();
			return topics.Select(t => t.TopicValue);
		}

		public async Task AddTopicAsync(string topic) {
			topics.Add(new Topic { TopicValue = topic });
			await http.PostJsonAsync("api/topics", topics);
		}

		public async Task RemoveTopicAsync(string topic) {
			topics.RemoveAll(t => t.TopicValue == topic);
			await http.PostJsonAsync("api/topics", topics);
		}

	}
}
