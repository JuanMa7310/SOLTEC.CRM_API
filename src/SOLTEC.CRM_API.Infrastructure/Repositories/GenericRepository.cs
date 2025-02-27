using Microsoft.EntityFrameworkCore;
using SOLTEC.CRM_API.Domain.Entities;
using SOLTEC.CRM_API.Domain.Repositories;
using SOLTEC.CRM_API.Infrastructure.Persistence;

namespace SOLTEC.CRM_API.Infrastructure.Repositories;

public class GenericRepository<TEntity>(AppDbContext context) : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AppDbContext _context = context;

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
