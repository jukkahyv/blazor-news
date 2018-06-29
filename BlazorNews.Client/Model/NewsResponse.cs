using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNews.Client.Model {
	public class NewsResponse {
		public Article[] Articles { get; set; }
		public int TotalResults { get; set; }
	}
}
