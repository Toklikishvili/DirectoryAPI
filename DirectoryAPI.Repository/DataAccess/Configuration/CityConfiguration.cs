using DirectoryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryAPI.Repository.DataAccess.Configuration;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder
            .HasKey(c => c.Id);
        builder
            .HasMany(c => c.Persons)
            .WithOne(p => p.City)
            .HasForeignKey(p => p.CityId);
    }
}
