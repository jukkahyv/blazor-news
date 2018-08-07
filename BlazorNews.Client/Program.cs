using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using BlazorNews.Client.Repositories;
using Microsoft.AspNetCore.Blazor.Hosting;

namespace BlazorNews.Client {
	public class Program {
		static void Main(string[] args) {
			CreateHostBuilder(args).Build().Run();
		}

		public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
			BlazorWebAssemblyHost.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();

	}
}
