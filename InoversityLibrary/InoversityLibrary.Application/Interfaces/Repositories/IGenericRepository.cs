using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InoversityLibrary.Domain.Common.Interfaces;

namespace InoversityLibrary.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class, IEntity
{
    IQueryable<T> Entities { get; }
 
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}