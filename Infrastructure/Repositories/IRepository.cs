namespace Infrastructure.Repositories;

public interface IRepository<T>
    where T : class
{
    void Add(T entity);
    void Delete(T entity);
    void DeleteRange(IEnumerable<T> entities);
    void Update(T entity);
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();

    IQueryable<T> GetQueryable();
}
