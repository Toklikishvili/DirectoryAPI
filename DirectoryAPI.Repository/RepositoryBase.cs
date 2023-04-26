using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Repository.DataAccess;
using System.Linq.Expressions;

namespace DirectoryAPI.Repository;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    protected readonly DirectoryAPIDbContext _context;
    protected RepositoryBase(DirectoryAPIDbContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    public virtual TEntity Get(object id) =>
        _context.Set<TEntity>().Find(id) ?? throw new KeyNotFoundException($"Record with key {id} not found");

    public virtual IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> predicate) =>
        _context.Set<TEntity>().Where(predicate);

    public virtual IQueryable<TEntity> SelectAll() => _context.Set<TEntity>();

    public virtual void Insert(TEntity entity) => _context.Add(entity);

    public virtual void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

    public virtual void Delete(object id) => Delete(Get(id));

    public int SaveChanges() => _context.SaveChanges();

    public virtual void Dispose() => _context?.Dispose();
}
