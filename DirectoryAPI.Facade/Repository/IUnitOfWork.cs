namespace DirectoryAPI.Facade.Repository;

public interface IUnitOfWork
{
    IPersonRepository PersonRepository { get; }
    ICityRepository ICityRepository { get; }
    IRelatedPersonRepository IRelatedPersonRepository { get; }
    int SaveChanges();
}
