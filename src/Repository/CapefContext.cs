using Capef.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Capef.Repository;

public class CapefContext : DbContext
{
  public DbSet<Employee> Employees { get; set; }= default!;

  public CapefContext(DbContextOptions options) : base(options) {}

  public CapefContext() {}

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if(!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=Capef_Staff;User=SA;Password=Capef@2023;TrustServerCertificate=true");
    }
  }

}