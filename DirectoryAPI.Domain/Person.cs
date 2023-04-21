using DirectoryAPI.Domain.Enumeration;

namespace DirectoryAPI.Domain;

public sealed class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? PersonalNumber { get; set; }
    public string? Image { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public NumberType NumberType { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;


    public int CityId { get; set; }
    public City? City { get; set; }

    public ICollection<RelatedPerson>? RelatedPersons { get; set; }
}