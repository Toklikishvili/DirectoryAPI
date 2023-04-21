using DirectoryAPI.Domain;
using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Repository.DataAccess;

namespace DirectoryAPI.Repository;

public sealed class CityRepository : RepositoryBase<City>, ICityRepository
{
    public CityRepository(DirectoryAPIDbContext context) : base(context) { }
}
