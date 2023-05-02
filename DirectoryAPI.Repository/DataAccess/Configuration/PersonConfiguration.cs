using DirectoryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryAPI.Repository.DataAccess.Configuration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.Property(p => p.Surname).HasMaxLength(50);
        builder.Property(p => p.PersonalNumber).HasMaxLength(11);
        builder.Property(p => p.Image).HasMaxLength(255);
        builder.Property(p => p.DateOfBirth).IsRequired();
        builder.Property(p => p.Gender).IsRequired();
        builder.Property(p => p.NumberType).IsRequired();
        builder.Property(p => p.PhoneNumber).HasMaxLength(20).IsRequired();

        builder.HasMany(p => p.RelatedPersons)
            .WithOne(rp => rp.Person)
            .HasForeignKey(rp => rp.PersonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.RelationPerson)
            .WithOne(rp => rp.RelationPerson)
            .HasForeignKey(rp => rp.RelationPersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    //public void Configure(EntityTypeBuilder<Person> builder)
    //{
    //    builder
    //        .HasKey(p => p.Id);
    //    builder
    //        .Property(p => p.Name)
    //        .IsRequired()
    //        .HasAnnotation("RegularExpression", @"^[a-zA-Zა-ჰ]{2,50}$");
    //    builder
    //        .Property(p => p.Surname)
    //        .IsRequired()
    //        .HasAnnotation("RegularExpression", @"^[a-zA-Zა-ჰ]{2,50}$");
    //    builder
    //        .Property(p => p.PersonalNumber)
    //        .IsRequired()
    //        .HasAnnotation("RegularExpression", @"^\d{11}$");
    //    builder
    //        .Property(p => p.DateOfBirth)
    //        .IsRequired()
    //        .HasAnnotation("MinimumAge", 18);
    //    builder
    //        .Property(p => p.PhoneNumber)
    //        .HasAnnotation("RegularExpression", @"^[a-zA-Z0-9]{4,50}$");
    //}
}
