using DirectoryAPI.Domain.Enumeration;

namespace DirectoryAPI.Domain;

public sealed class RelatedPerson
{
    public int Id { get; set; }
    public ConnectionType ConnectionType { get; set; }

    public int PersonId { get; set; }
    public Person? Person { get; set; }

    public int RelationPersonId { get; set; }
    public Person? RelationPerson { get; set; }  
}