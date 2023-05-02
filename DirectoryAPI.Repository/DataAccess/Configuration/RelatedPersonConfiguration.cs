using DirectoryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryAPI.Repository.DataAccess.Configuration;

public class RelatedPersonConfiguration : IEntityTypeConfiguration<RelatedPerson>
{
    public void Configure(EntityTypeBuilder<RelatedPerson> builder)
    {
        builder.HasKey(rp => new { rp.PersonId, rp.RelationPersonId });

        builder.HasOne(rp => rp.Person)
            .WithMany(p => p.RelatedPersons)
            .HasForeignKey(rp => rp.PersonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(rp => rp.RelationPerson)
            .WithMany(p => p.RelationPerson)
            .HasForeignKey(rp => rp.RelationPersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
