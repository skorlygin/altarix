using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace WebApi.Models
{
	public sealed class ApiDbContext : DbContext
	{
		public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
		{
		}

		public DbSet<Message> Messages { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			var factory = new LoggerFactory();
			factory.AddProvider(new NLogLoggerProvider());
			optionsBuilder.UseLoggerFactory(factory);
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Message>().HasKey(__message => __message.Id);
			builder.Entity<Message>().Property(__message => __message.Text).IsRequired();
			builder.Entity<Message>().Property(__message => __message.CreateDate).IsRequired();
			builder.Entity<Message>().HasOne(__message => __message.Question);
		}
	}
}