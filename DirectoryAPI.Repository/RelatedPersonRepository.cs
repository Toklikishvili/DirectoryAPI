using DirectoryAPI.Domain;
using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Repository.DataAccess;

namespace DirectoryAPI.Repository;

public sealed class RelatedPersonRepository : RepositoryBase<RelatedPerson>, IRelatedPersonRepository
{
    public RelatedPersonRepository(DirectoryAPIDbContext context) : base(context) { }
}
