using System.Data.Common;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<VisitEntity> Visits { get; set; }
}