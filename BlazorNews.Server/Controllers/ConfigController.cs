using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNews.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BlazorNews.Server.Controllers {

	public class ConfigController : Controller {

		private readonly Config config;

		public ConfigController(IOptions<Config> config) {
			this.config = config.Value;
		}

		[HttpGet("api/config")]
		public Config Get() {
			return config;
		}

	}
}
