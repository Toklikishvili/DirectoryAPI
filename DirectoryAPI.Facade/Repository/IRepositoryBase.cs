using System.Linq.Expressions;

namespace DirectoryAPI.Facade.Repository;

public interface IRepositoryBase<TEntity>: IDisposable where TEntity : class
{
    TEntity Get(object id);
    IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    IQueryable<TEntity> SelectAll();
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(object id);
    int SaveChanges();
}
