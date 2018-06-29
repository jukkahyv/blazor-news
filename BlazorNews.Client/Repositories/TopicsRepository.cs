using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNews.Client.Repositories {
	public class TopicsRepository {

		private static List<string> topics = new List<string> {"Blazor"};

		public IEnumerable<string> GetTopics() {
			return topics;
		}

		public void AddTopic(string topic) {
			topics.Add(topic);
		}

		public void RemoveTopic(string topic) {
			topics.Remove(topic);
		}

	}
}
