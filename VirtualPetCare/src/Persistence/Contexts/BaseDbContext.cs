using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Persistence.Contexts;

public class BaseDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
    : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    protected IConfiguration Configuration { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}