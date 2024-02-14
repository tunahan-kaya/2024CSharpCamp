using Day2Task3.Core.Entities;
using System.Linq.Expressions;

namespace Day2Task3.Core.DataAccess.EntityFramework;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    T Get(Expression<Func<T, bool>> filter);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
