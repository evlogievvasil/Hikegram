namespace Hikegram.Data.Repositories.Common
{
  public interface IRepository<T> where T : class
  {
    Task<IEnumerable<T>> GetAll();
    Task<T?> Get(int id);
    Task Insert(T entity);
    Task Update(T entity);
    Task Delete(T entity);
  }
}