using DirectoryAPI.Domain;
using DirectoryAPI.Repository.DataAccess.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DirectoryAPI.Repository.DataAccess;

public class DirectoryAPIDbContext : DbContext
{
    public DirectoryAPIDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new RelatedPersonConfiguration());
    }

    public DbSet<City> Citys { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<RelatedPerson> RelatedPersons { get; set; }
}