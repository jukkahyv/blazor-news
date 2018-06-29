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
		public async Task Update([FromBody] Topic[] topics) {
			var newVals = topics.Select(t => t.TopicValue).ToHashSet();
			var old = db.Topics.Select(t => t.TopicValue).ToHashSet();
			var add = newVals.Except(old);
			var remove = old.Except(newVals);

			foreach (var t in add) {
				await db.Topics.AddAsync(new Topic { TopicValue = t });
			}

			foreach (var t in remove) {
				var oldTopic = db.Topics.First(t2 => t2.TopicValue == t);
				db.Topics.Remove(oldTopic);
			}

			await db.SaveChangesAsync();

		}

	}
}
