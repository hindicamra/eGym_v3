using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DataBaseContext _context;

    public GenericRepository(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(object id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task Insert(T obj)
    {
        await _context.Set<T>().AddAsync(obj);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T obj)
    {
        _context.Set<T>().Update(obj);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(object id)
    {
        T existing = await _context.Set<T>().FindAsync(id);
        _context.Set<T>().Remove(existing);
        await _context.SaveChangesAsync();
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().Where(predicate).ToListAsync();
    }
}

