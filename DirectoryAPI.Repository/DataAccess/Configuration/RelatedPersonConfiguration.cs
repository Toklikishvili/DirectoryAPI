using DirectoryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryAPI.Repository.DataAccess.Configuration;

public class RelatedPersonConfiguration : IEntityTypeConfiguration<RelatedPerson>
{
    public void Configure(EntityTypeBuilder<RelatedPerson> builder)
    {
        builder.HasKey(rp => rp.Id);
        builder.Property(rp => rp.ConnectionType).IsRequired();

        builder.HasOne(rp => rp.Person)
            .WithMany(p => p.RelatedPersons)
            .HasForeignKey(rp => rp.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(rp => rp.RelationPerson)
            .WithMany(p => p.RelationPerson)
            .HasForeignKey(rp => rp.RelationPersonId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
