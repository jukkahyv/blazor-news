using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BlazorNews.Server.Database;
using BlazorNews.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorNews.Server.Controllers {

	public class TopicsController : Controller {

		private readonly NewsDbContext db;

		public TopicsController(NewsDbContext db) {
			this.db = db;
		}

		[HttpGet("api/topics")]
		public IEnumerable<Topic> Get() {
			return db.Topics;
		}

		[HttpPost("api/topics")]
		public async Task Add([FromBody] Topic topic) {
			await db.Topics.AddAsync(topic);
			await db.SaveChangesAsync();
		}

		[HttpDelete("api/topics")]
		public async Task Delete(string topic) {
			var oldTopic = db.Topics.FirstOrDefault(t => t.TopicValue == topic);
			if (oldTopic != null)
				db.Topics.Remove(oldTopic);
			await db.SaveChangesAsync();
		}

	}
}
