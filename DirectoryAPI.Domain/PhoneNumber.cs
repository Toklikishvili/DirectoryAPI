using DirectoryAPI.Domain.Enumeration;

namespace DirectoryAPI.Domain;

public sealed class PhoneNumber
{
    public int Id { get; set; }
    public NumberType PhoneType { get; set; }

    public int PersonId { get; set; }
    public Person? Person { get; set; }
}
