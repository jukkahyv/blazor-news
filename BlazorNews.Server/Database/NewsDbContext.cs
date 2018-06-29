using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNews.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorNews.Server.Database {

	public class NewsDbContext : DbContext {

		public NewsDbContext(DbContextOptions<NewsDbContext> options) : base((DbContextOptions)options) { }

		public DbSet<Topic> Topics { get; set; }

	}

}
