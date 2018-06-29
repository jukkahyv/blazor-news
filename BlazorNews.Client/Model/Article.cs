using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNews.Client.Model {
	public class Article {
		public string Author { get; set; }
		public string Description { get; set; }
		public DateTime PublishedAt { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public string UrlToImage { get; set; }
	}
}
