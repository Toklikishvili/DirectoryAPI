using DirectoryAPI.Domain;
using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Repository.DataAccess;

namespace DirectoryAPI.Repository;

public sealed class PersonRepository : RepositoryBase<Person>, IPersonRepository
{
    public PersonRepository(DirectoryAPIDbContext context) : base(context) { }
}
