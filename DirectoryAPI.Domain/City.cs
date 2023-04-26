using DirectoryAPI.Domain.Enumeration;

namespace DirectoryAPI.Domain;

public sealed class City
{
    public int Id { get; set; }
    public CityEnum CityEnum { get; set; }

    public ICollection<Person>? Persons { get; set; }
}