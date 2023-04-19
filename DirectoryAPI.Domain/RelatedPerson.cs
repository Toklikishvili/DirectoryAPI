using DirectoryAPI.Domain.Enumeration;

namespace DirectoryAPI.Domain;

public sealed class RelatedPerson
{
    public int Id { get; set; }
    public ConnectionType ConnectionType { get; set; }
}