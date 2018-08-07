using BlazorNews.Client.Repositories;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace BlazorNews.Client {
	public class Startup {
		public void ConfigureServices(IServiceCollection services) {
			// Add any custom services here
			services.Add(ServiceDescriptor.Singleton(s => new TopicsRepository((HttpClient)s.GetService(typeof(HttpClient)))));
		}

		public void Configure(IBlazorApplicationBuilder app) {
			app.AddComponent<App>("app");
		}
	}
}
