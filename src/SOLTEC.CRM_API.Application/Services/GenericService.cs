using SOLTEC.CRM_API.Application.Interfaces;
using SOLTEC.CRM_API.Domain.Repositories;

namespace SOLTEC.CRM_API.Application.Services;

public class GenericService<TDTO, TEntity>(IGenericRepository<TEntity> repository) : IGenericService<TDTO>
    where TDTO : class
    where TEntity : class
{
    protected readonly IGenericRepository<TEntity> _repository = repository;

    protected virtual TDTO MapToDto(TEntity entity) => throw new NotImplementedException();
    protected virtual TEntity MapToEntity(TDTO dto) => throw new NotImplementedException();

    public async Task<IEnumerable<TDTO>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => MapToDto(e));
    }

    public async Task<TDTO?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity == null ? null : MapToDto(entity);
    }

    public async Task<TDTO> CreateAsync(TDTO dto)
    {
        var entity = MapToEntity(dto);
        var createdEntity = await _repository.AddAsync(entity);
        return MapToDto(createdEntity);
    }

    public async Task UpdateAsync(TDTO dto)
    {
        var entity = MapToEntity(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
