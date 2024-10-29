using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T>
    where T : class
{
    private readonly DbSet<T> _entities;

    public Repository(BookHubDbContext context)
    {
        _entities = context.Set<T>();
    }

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public void Delete(T entity)
    {
        _entities.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        _entities.RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _entities.Update(entity);
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _entities.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entities.ToListAsync();
    }
}
