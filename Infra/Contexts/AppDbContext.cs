using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=atendimento;User Id=sa;Password=admin;TrustServerCertificate=True;Trusted_Connection=true");
    }
    public DbSet<Patient> Patients { get; set; }
}