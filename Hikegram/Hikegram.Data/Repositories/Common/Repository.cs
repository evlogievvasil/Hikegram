using Microsoft.EntityFrameworkCore;

namespace Hikegram.Data.Repositories.Common
{
  public class Repository<T> : IRepository<T> where T : BaseEntity
  {
    private readonly HikegramDbContext _context;
    private DbSet<T> _entities;

    public Repository(HikegramDbContext context)
    {
      _context = context;
      _entities = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
      return await _entities.ToListAsync();
    }

    public async Task<T?> Get(int id)
      => await _entities.FirstOrDefaultAsync(s => s.Id == id);

    public async Task Insert(T entity)
    {
      if (entity == null)
        throw new ArgumentNullException("Невалидно подаден елемент за запис.");

      await _entities.AddAsync(entity);
      await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
      if (entity == null)
        throw new ArgumentNullException("Невалидно подаден елемент за актуализация.");

      if (!_entities.Contains(entity))
        throw new ArgumentNullException("Несъществуващ елемент за актуализация.");

      _entities.Update(entity);
      await _context.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
      if (entity == null)
        throw new ArgumentNullException("Невалидно подаден елемент за изтриване.");

      _entities.Remove(entity);
      await _context.SaveChangesAsync();
    }
  }
}
