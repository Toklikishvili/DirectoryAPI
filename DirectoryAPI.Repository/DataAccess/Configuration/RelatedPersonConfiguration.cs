using DirectoryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryAPI.Repository.DataAccess.Configuration;

public class RelatedPersonConfiguration : IEntityTypeConfiguration<RelatedPerson>
{
    public void Configure(EntityTypeBuilder<RelatedPerson> builder)
    {
        builder
            .HasKey(r=>r.Id);
        builder
            .HasOne(r => r.Person)
            .WithMany(p => p.RelatedPersons)
            .HasForeignKey(r => r.PersonId);
    }
}
