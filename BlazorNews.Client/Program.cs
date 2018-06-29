using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using BlazorNews.Client.Repositories;

namespace BlazorNews.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
				services.Add(ServiceDescriptor.Singleton(new TopicsRepository()));
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
