using Microsoft.EntityFrameworkCore;
using MyEnglish.Domain;
using MyEnglish.Helper.Constants;

namespace MyEnglish.Infra.Context;

public class MyEnglishContext : DbContext
{
	public MyEnglishContext() { }

	public MyEnglishContext(DbContextOptions<MyEnglishContext> options) : base(options) { }

	// Tables
	public DbSet<Palavra> Palavras { get; set; }

	// Overrides
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyEnglishContext).Assembly);
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		optionsBuilder.UseSqlServer(SharedConstants.connectionString);
	}
}