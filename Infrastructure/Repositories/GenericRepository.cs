using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<T> : IRepository<T>
    where T : class
{
    private readonly DbSet<T> _entities;

    public GenericRepository(BookHubDbContext context)
    {
        _entities = context.Set<T>();
    }

    public async void Add(T entity)
    {
        await _entities.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _entities.Remove(entity);
    }

    public void Update(T entity)
    {
        _entities.Update(entity);
    }

    public async Task<T?> GetById(int id)
    {
        return await _entities.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _entities.ToListAsync();
    }
}
